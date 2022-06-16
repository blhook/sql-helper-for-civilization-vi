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

using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Reflection;

namespace Test.ORM
{
    public class BaseDBContext : DbContext
    {
        List<PropertyInfo> _TableNames;
        public List<PropertyInfo> TableNames
        {
            get
            {
                if (_TableNames == null)
                    _TableNames = this.GetType().GetProperties().Where(u => u.GetGetMethod().IsVirtual).ToList();//this.Database.SqlQuery<string>("SELECT name FROM sqlite_master WHERE type = 'table' ORDER BY 1").ToList();

                return _TableNames;
            }
        }

        public BaseDBContext(DbConnection existingConnection, bool contextOwnsConnection) : base(existingConnection, contextOwnsConnection)
        {
            //this.Configuration.LazyLoadingEnabled = false;
        }

        public new List<string> SaveChanges()
        {
            bool debugEntry = true;

            //Debug only to verify changes
            if (debugEntry)
            {
                var tracked = ChangeTracker.Entries();

                List<DbEntityEntry> all = new List<DbEntityEntry>();
                List<DbEntityEntry> added = new List<DbEntityEntry>();
                List<DbEntityEntry> unchanged = new List<DbEntityEntry>();
                List<DbEntityEntry> deleted = new List<DbEntityEntry>();
                List<DbEntityEntry> edited = new List<DbEntityEntry>();

                foreach (var entity in tracked)
                {
                    if (entity.State == EntityState.Added)
                        added.Add(entity);
                    else if (entity.State == EntityState.Deleted)
                        deleted.Add(entity);
                    else if (entity.State == EntityState.Modified)
                        edited.Add(entity);
                    else if (entity.State == EntityState.Unchanged)
                        unchanged.Add(entity);

                    all.Add(entity);
                }
            }

            int returnSave = 0;
            List<string> fs = new List<string>();
            this.Database.Log = s => fs.Add(s);

            returnSave = base.SaveChanges();

            return fs;
        }
    }
}
