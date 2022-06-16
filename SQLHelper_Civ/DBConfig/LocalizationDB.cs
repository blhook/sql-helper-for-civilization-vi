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

using System.Data.Entity;
using System.Data.SQLite;
using System.IO;
using Test.ORM.Localization;

namespace Test.ORM
{
    public partial class LocalizationDB : BaseDBContext
    {
        public LocalizationDB() : base((new SQLiteConnection()
        {
            ConnectionString =
                                                                                            new SQLiteConnectionStringBuilder()
                                                                                            { DataSource = Path.Combine(SQLHelper_Civ.Properties.Settings.Default.LocalizationPath), ForeignKeys = true }
                                                                                            .ConnectionString
        }), true)
        {
        }

        public virtual DbSet<AudioLanguages> AudioLanguages { get; set; }
        public virtual DbSet<DefaultAudioLanguages> DefaultAudioLanguages { get; set; }
        public virtual DbSet<FontStyleSheets> FontStyleSheets { get; set; }
        public virtual DbSet<LanguagePriorities> LanguagePriorities { get; set; }
        public virtual DbSet<LocalizedText> LocalizedText { get; set; }
        public virtual DbSet<SteamLanguages> SteamLanguages { get; set; }
        public virtual DbSet<Languages> Languages { get; set; }
        //public virtual DbSet<BaseGameText> BaseGameText { get; set; }
        //public virtual DbSet<EnglishText> EnglishText { get; set; }
        //public virtual DbSet<FrontEndText> FrontEndText { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            #region Model Auto-Created
            modelBuilder.Entity<LanguagePriorities>()
                .HasKey(u => new { u.Language, u.PrimaryLanguage });

            modelBuilder.Entity<LocalizedText>()
                .HasKey(u => new { u.Language, u.Tag });

            modelBuilder.Entity<AudioLanguages>()
                .HasMany(e => e.DefaultAudioLanguages)
                .WithRequired(e => e.AudioLanguages)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LanguagePriorities>()
                .HasRequired(f => f.Language1)
                .WithMany(t => t.LanguagePriorities)
                .HasForeignKey(t => t.PrimaryLanguage)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LanguagePriorities>()
                .HasRequired(f => f.Language2)
                .WithMany(t => t.LanguagePriorities2)
                .HasForeignKey(t => t.Language)
                .WillCascadeOnDelete(false);
            #endregion Model Auto-Created
        }
    }
}
