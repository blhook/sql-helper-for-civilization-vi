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
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using Test.ORM;

namespace SQLHelper_Civ.Extensions_Helpers
{
    class Classes
    {
        [DebuggerDisplay("Table = {Table.Name}; PK = {PrimaryKeys[0].Name}")]
        public class TablePropertyHolder
        {
            //We have a few cross-Context references, so we need this for that. 
            public BaseDBContext Context { get; set; }

            public PropertyInfo Table { get; set; }

            public Type UnderlyingType => Table.PropertyType.GetGenericArguments().Single();

            public List<PropertyInfo> PrimaryKeys { get; set; } = new List<PropertyInfo>();

            public List<PropertyInfo> RequiredItems { get; set; } = new List<PropertyInfo>();

            /// <summary>
            /// Holds all of the FKs, and their links.
            /// </summary>
            public List<ForeignKeyMapper> ForeignKeys { get; set; } = new List<ForeignKeyMapper>();

            /// <summary>
            /// Holds all items that reference the certain table. No content is held in this one. 
            /// </summary>
            public List<InverseForeignKeyMapper> InverseForeignKeys { get; set; } = new List<InverseForeignKeyMapper>();

            /// <summary>
            /// Holds all of the items from the class in a cache, to make re-loading smoother. 
            /// </summary>
            public BindingList<object> LoadedItems { get; set; }
        }

        public class ForeignKeyMapper
        {
            public PropertyInfo LocalProperty { get; set; }
            public TablePropertyHolder LocalTable { get; set; }

            public string LocalPropertyAccessorName { get; set; }

            /// <summary>
            /// Holds the name of the reference context, for when we actually don't have it loaded in yet. 
            /// </summary>
            public string ReferenceContextName { get; set; }
            /// <summary>
            /// Holds the name of the reference table, for when we actually don't have it loaded in yet. 
            /// </summary>
            public string ReferenceTableName { get; set; }

            /// <summary>
            /// If left as null, this will default to the PK. Used, primarily, for cross-context FKs. 
            /// </summary>
            public string ReferencePropertyName { get; set; }

            public TablePropertyHolder ReferencedTable { get; set; }
        }

        public class ForeignKeyHolder
        {
            public string ReferenceContextName { get; set; }
            public string ReferenceTableName { get; set; }
            public string ReferencePropertyName { get; set; }

            public string LocalPropertyName { get; set; }
            public string LocalPropertyAccessorName { get; set; }

            public ForeignKeyHolder(string context, string table, string refProp, string localProp, string localPropAccessor)
            {
                ReferenceContextName = context;
                ReferenceTableName = table;
                ReferencePropertyName = refProp;

                LocalPropertyName = localProp;
                LocalPropertyAccessorName = localPropAccessor;
            }
        }

        public class InverseForeignKeyMapper
        {
            public bool IsCollection { get; set; } = true;
            public Type ReferenceTableType { get; set; }
            public string ReferencedFromTableName => ReferenceTableType.Name;

            public string LocalPropertyName { get; set; }
            public string LocalPropertyAccessorName { get; set; }
            public string InversePropertyName { get; set; }
        }

        public class CrossContextForeignKey : Attribute
        {
            public string Context { get; set; }
            public string Table { get; set; }
            public string Property { get; set; }

            public CrossContextForeignKey(string context, string table, string property)
            {
                Context = context;
                Table = table;
                Property = property;
            }
        }
    }
}
