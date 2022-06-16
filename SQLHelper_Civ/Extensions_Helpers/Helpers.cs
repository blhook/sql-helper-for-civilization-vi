// Copyright (C) 2022 Brandon Hook
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Reflection;
using static SQLHelper_Civ.Extensions_Helpers.Classes;

namespace SQLHelper_Civ.Extensions_Helpers
{
    static class Helpers
    {
        public static List<InverseForeignKeyMapper> GetInverseForeignKeys(DbContext context, Type type, List<ForeignKeyHolder> fks)
        {
            List<InverseForeignKeyMapper> returnHolder = new List<InverseForeignKeyMapper>();

            var virtuals = type.GetProperties().Where(u => u.GetGetMethod().IsVirtual).ToList();

            foreach (var reference in virtuals)
            {
                //Scenario 1: Basic Referenced From scenario. 
                if (reference.PropertyType.IsGenericType == true)
                {
                    InverseForeignKeyMapper mapper = new InverseForeignKeyMapper();
                    Type realType = reference.PropertyType.GetGenericArguments().Single();

                    mapper.IsCollection = true;
                    mapper.ReferenceTableType = realType;
                    mapper.LocalPropertyAccessorName = reference.Name;
                    mapper.InversePropertyName = ReturnInversePropertyName(reference);

                    returnHolder.Add(mapper);
                }
                //Scenario 2: Determine if it is actually being referenced or it is referencing through looking at the FKs and filtering down. 
                else
                {

                }
            }

            return returnHolder;
        }

        public static (List<ForeignKeyHolder> ForeignKeys, List<InverseForeignKeyMapper> InverseForeignKeys) GetForeignKeys(DbContext context, Type type)
        {
            List<ForeignKeyHolder> returnFKHolder = new List<ForeignKeyHolder>();
            List<InverseForeignKeyMapper> returnIFKHolder = new List<InverseForeignKeyMapper>();

            var cspace = GetForeignKeys_CSpace(context, type);
            var cspaceReferences = cspace.ForeignKeys;
            returnIFKHolder = cspace.InverseForeignKeys;
            foreach (ForeignKeyHolder item in cspaceReferences)
            {
                item.ReferenceContextName = ContextSwitcher(context);
            }

            if (cspaceReferences != null)
                returnFKHolder.AddRange(cspaceReferences);

            if (Properties.Settings.Default.CrossContext)
            {
                var crossRef = GetForeignKeys_CrossContext(type);
                if (crossRef != null)
                    returnFKHolder.AddRange(crossRef);
            }

            return (returnFKHolder, returnIFKHolder);
        }

        public static string ContextSwitcher(DbContext context)
        {
            if (context.GetType().Name.Contains(Globals.Globals.ConfigurationName))
                return Globals.Globals.ConfigurationName;
            else if (context.GetType().Name.Contains(Globals.Globals.LocalizationName))
                return Globals.Globals.LocalizationName;
            else if (context.GetType().Name.Contains(Globals.Globals.GameplayName))
                return Globals.Globals.GameplayName;

            return null;
        }

        //Modified from Source: https://stackoverflow.com/a/30773384
        /// <summary>
        /// This gets the type name of the property and a Type it is associated with. 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="tableType"></param>
        /// <returns></returns>
        private static (List<ForeignKeyHolder> ForeignKeys, List<InverseForeignKeyMapper> InverseForeignKeys) GetForeignKeys_CSpace(DbContext context, Type tableType)
        {
            var tables = context.GetType().GetProperties().Where(u => u.GetGetMethod().IsVirtual).Select(u => u.PropertyType.GetGenericArguments().Single()).ToList();
            List<ForeignKeyHolder> searchFK = new List<ForeignKeyHolder>();
            List<InverseForeignKeyMapper> searchIFK = new List<InverseForeignKeyMapper>();

            StructuralType edmType = GetCSpaceType(context, tableType);

            var members = edmType
                                .MetadataProperties
                                .Where(mp => mp.Name == "Members")
                                .FirstOrDefault();
            if (members != null && members.Value != null)
            {
                List<NavigationProperty> navProps = ((ICollection<EdmMember>)members.Value)
                                                    .Where(m => m.BuiltInTypeKind == BuiltInTypeKind.NavigationProperty)
                                                    .Cast<NavigationProperty>()
                                                    .Where(p =>
                                                        ((AssociationType)p.RelationshipType).IsForeignKey
                                                    )
                                                    .ToList();
                List<EdmProperty> foreignKeys = navProps
                                                .SelectMany(p => p.GetDependentProperties())
                                                .ToList();
                foreach (var fk in navProps)
                {
                    var dependencies = fk.GetDependentProperties();
                    var type = ((RefType)fk.ToEndMember.TypeUsage.EdmType).ElementType;

                    var toProp = ((AssociationType)fk.RelationshipType).Constraint.ToProperties?.FirstOrDefault();
                    var fromProp = ((AssociationType)fk.RelationshipType).Constraint.FromProperties?.FirstOrDefault();

                    //If it has dependent, then it is a true FK (our table referencing another).
                    //If it doesn't have a dependency, then it it being referenced by the other table. 
                    if (dependencies.Any())
                    {
                        searchFK.Add(new ForeignKeyHolder(null, type.Name, fromProp.Name, dependencies.FirstOrDefault()?.Name, fk.Name));
                    }
                    else
                    {
                        var newInverseFK = new InverseForeignKeyMapper();
                        newInverseFK.InversePropertyName = toProp.Name;
                        newInverseFK.LocalPropertyName = fromProp.Name;
                        newInverseFK.LocalPropertyAccessorName = fk.Name;
                        newInverseFK.ReferenceTableType = tables.FirstOrDefault(u => u.Name == type.Name);
                        searchIFK.Add(newInverseFK);
                    }
                }
                return (searchFK, searchIFK);// foreignKeys.Select(p => p.Name).ToArray();
            }
            return (null, null);
        }

        private static List<ForeignKeyHolder> GetForeignKeys_CrossContext(Type tableType)
        {
            List<ForeignKeyHolder> returnList = new List<ForeignKeyHolder>();

            foreach (var prop in tableType.GetProperties())
            {
                var attribute = prop.GetCustomAttribute(typeof(CrossContextForeignKey)) as CrossContextForeignKey;
                if (attribute != null)
                    returnList.Add(new ForeignKeyHolder(attribute.Context, attribute.Table, attribute.Property, prop.Name, null));
            }

            if (returnList.Any())
                return returnList;
            else
                return null;
        }

        //Source: https://stackoverflow.com/a/8550614
        public static Type FindUnderylingNullableType(Type type)
        {
            if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                return Nullable.GetUnderlyingType(type);
            }
            return null;
        }

        //Source: https://stackoverflow.com/a/30773384
        private static StructuralType GetCSpaceType(DbContext context, Type type)
        {
            MetadataWorkspace workspace = ((IObjectContextAdapter)context).ObjectContext.MetadataWorkspace;
            EdmType ospaceType = workspace.GetType(type.Name, type.Namespace, DataSpace.OSpace);
            return workspace.GetEdmSpaceType((StructuralType)ospaceType);
        }

        private static string ReturnInversePropertyName(PropertyInfo prop)
        {
            System.Object[] attributes = prop.GetCustomAttributes(true);
            foreach (object attribute in attributes)
            {
                if (attribute is InversePropertyAttribute)
                {
                    return (attribute as InversePropertyAttribute).Property;
                }
            }

            return string.Empty;
        }
    }
}
