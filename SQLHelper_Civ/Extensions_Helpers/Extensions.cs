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
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace SQLHelper_Civ.Extensions_Helpers
{
    static class Extensions
    {
        //Source: https://nickotech2000.blogspot.com/2009/11/make-ienumerable-to-bindinglist.html
        public static BindingList<T> ToBindingList<T>(this IEnumerable<T> data)
        {
            BindingList<T> result = null;
            if (data != null)
            {
                result = new BindingList<T>();
                foreach (T item in data)
                {
                    result.Add(item);
                }
            }
            return result;
        }

        //Source: https://stackoverflow.com/a/24823445
        /// <summary>
        /// Returns the set of items, made distinct by the selected value.
        /// </summary>
        /// <typeparam name="TSource">The type of the source.</typeparam>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="source">The source collection.</param>
        /// <param name="selector">A function that selects a value to determine unique results.</param>
        /// <returns>IEnumerable&lt;TSource&gt;.</returns>
        public static IEnumerable<TSource> DistinctBy<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
        {
            HashSet<TResult> set = new HashSet<TResult>();

            foreach (var item in source)
            {
                var selectedValue = selector(item);

                if (set.Add(selectedValue))
                    yield return item;
            }
        }

        public static List<PropertyInfo> GetPrimaryKeysInfo(this Type type)
        {
            List<PropertyInfo> returnKeys = new List<PropertyInfo>();
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo pI in properties)
            {
                System.Object[] attributes = pI.GetCustomAttributes(true);
                foreach (object attribute in attributes)
                {
                    if (attribute is KeyAttribute)
                    {
                        returnKeys.Add(pI);
                    }
                }
            }
            return returnKeys;
        }

        public static bool IsPropertyPrimaryKey(this PropertyInfo prop)
        {
            System.Object[] attributes = prop.GetCustomAttributes(true);
            foreach (object attribute in attributes)
            {
                if (attribute is KeyAttribute)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool IsPropertyRequired(this PropertyInfo prop)
        {
            System.Object[] attributes = prop.GetCustomAttributes(true);
            foreach (object attribute in attributes)
            {
                if (attribute is RequiredAttribute)
                {
                    return true;
                }
            }

            return false;
        }

        public static object GetPropertyValue<T>(this T entity, string name)
        {
            return entity.GetType().GetProperty(name).GetValue(entity, null);
        }

        //Source: https://stackoverflow.com/a/8809437
        public static string ReplaceFirst(this string text, string search, string replace)
        {
            int pos = text.IndexOf(search);
            if (pos < 0)
            {
                return text;
            }
            return text.Substring(0, pos) + replace + text.Substring(pos + search.Length);
        }

        public static string FirstWord(this string text)
        {
            return text.Contains(" ")
                  ? text.Substring(0, text.IndexOf(" "))
                  : text;
        }
    }
}
