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
using Test.ORM.Configuration;

namespace Test.ORM
{
    public partial class ConfigurationDB : BaseDBContext
    {
        public ConfigurationDB() : base((new SQLiteConnection()
        {
            ConnectionString =
                                                                                            new SQLiteConnectionStringBuilder()
                                                                                            { DataSource = Path.Combine(SQLHelper_Civ.Properties.Settings.Default.ConfigurationPath), ForeignKeys = true }
                                                                                            .ConnectionString
        }), true)
        {
        }

        public virtual DbSet<ConfigurationUpdateQueries> ConfigurationUpdateQueries { get; set; }
        public virtual DbSet<ConfigurationUpdates> ConfigurationUpdates { get; set; }
        public virtual DbSet<Credits> Credits { get; set; }
        public virtual DbSet<DataPointAggregateQueries> DataPointAggregateQueries { get; set; }
        public virtual DbSet<DataPointAggregateScopeQueries> DataPointAggregateScopeQueries { get; set; }
        public virtual DbSet<DataPointAggregateScopes> DataPointAggregateScopes { get; set; }
        public virtual DbSet<DataPointAggregateUpdates> DataPointAggregateUpdates { get; set; }
        public virtual DbSet<Defeats> Defeats { get; set; }
        public virtual DbSet<Difficulties_Configuration> Difficulties_Configuration { get; set; }
        public virtual DbSet<DomainOverrideQueries> DomainOverrideQueries { get; set; }
        public virtual DbSet<DomainOverrides> DomainOverrides { get; set; }
        public virtual DbSet<DomainRangeQueries> DomainRangeQueries { get; set; }
        public virtual DbSet<DomainRanges> DomainRanges { get; set; }
        public virtual DbSet<DomainValueFilterQueries> DomainValueFilterQueries { get; set; }
        public virtual DbSet<DomainValueFilters> DomainValueFilters { get; set; }
        public virtual DbSet<DomainValueQueries> DomainValueQueries { get; set; }
        public virtual DbSet<DomainValues> DomainValues { get; set; }
        public virtual DbSet<DomainValueUnionQueries> DomainValueUnionQueries { get; set; }
        public virtual DbSet<DomainValueUnions> DomainValueUnions { get; set; }
        public virtual DbSet<DuplicateCivilizations> DuplicateCivilizations { get; set; }
        public virtual DbSet<DuplicateLeaders> DuplicateLeaders { get; set; }
        public virtual DbSet<Eras> Eras { get; set; }
        public virtual DbSet<GameCores> GameCores { get; set; }
        public virtual DbSet<GameSpeeds> GameSpeeds { get; set; }
        public virtual DbSet<GraphQueries> GraphQueries { get; set; }
        public virtual DbSet<Graphs> Graphs { get; set; }
        public virtual DbSet<Highlights> Highlights { get; set; }
        public virtual DbSet<InputActionDefaultGestures> InputActionDefaultGestures { get; set; }
        public virtual DbSet<InputActions> InputActions { get; set; }
        public virtual DbSet<InputCategories> InputCategories { get; set; }
        public virtual DbSet<InputContexts> InputContexts { get; set; }
        public virtual DbSet<MapDomainOverrides> MapDomainOverrides { get; set; }
        public virtual DbSet<MapLeaders> MapLeaders { get; set; }
        public virtual DbSet<Maps> Maps { get; set; }
        public virtual DbSet<MapSizes> MapSizes { get; set; }
        public virtual DbSet<MapSupportedValues> MapSupportedValues { get; set; }
        public virtual DbSet<MapUnSupportedValues> MapUnSupportedValues { get; set; }
        public virtual DbSet<ParameterCriteria> ParameterCriteria { get; set; }
        public virtual DbSet<ParameterCriteriaQueries> ParameterCriteriaQueries { get; set; }
        public virtual DbSet<ParameterDependencies> ParameterDependencies { get; set; }
        public virtual DbSet<ParameterDependencyQueries> ParameterDependencyQueries { get; set; }
        public virtual DbSet<ParameterQueries> ParameterQueries { get; set; }
        public virtual DbSet<ParameterQueryCriteria> ParameterQueryCriteria { get; set; }
        public virtual DbSet<ParameterQueryDependencies> ParameterQueryDependencies { get; set; }
        public virtual DbSet<Parameters> Parameters { get; set; }
        public virtual DbSet<PlayerItems> PlayerItems { get; set; }
        public virtual DbSet<Players> Players { get; set; }
        public virtual DbSet<Queries> Queries { get; set; }
        public virtual DbSet<QueryCriteria> QueryCriteria { get; set; }
        public virtual DbSet<QueryParameters> QueryParameters { get; set; }
        public virtual DbSet<ReportColumns> ReportColumns { get; set; }
        public virtual DbSet<ReportQueries> ReportQueries { get; set; }
        public virtual DbSet<Reports> Reports { get; set; }
        public virtual DbSet<RulesetDomainOverrides> RulesetDomainOverrides { get; set; }
        public virtual DbSet<Rulesets> Rulesets { get; set; }
        public virtual DbSet<RulesetSupportedValues> RulesetSupportedValues { get; set; }
        public virtual DbSet<RulesetTypes> RulesetTypes { get; set; }
        public virtual DbSet<RulesetUnSupportedValues> RulesetUnSupportedValues { get; set; }
        public virtual DbSet<StatisticCategories> StatisticCategories { get; set; }
        public virtual DbSet<Statistics> Statistics { get; set; }
        public virtual DbSet<TurnPhases> TurnPhases { get; set; }
        public virtual DbSet<TurnTimers> TurnTimers { get; set; }
        public virtual DbSet<Victories> Victories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            #region Model Auto-Created
            modelBuilder.Entity<DataPointAggregateScopes>()
    .HasMany(e => e.DataPointAggregateUpdates)
    .WithRequired(e => e.DataPointAggregateScopes)
    .WillCascadeOnDelete(false);

            modelBuilder.Entity<Highlights>()
                .Property(e => e.MinValue)
                .HasPrecision(53, 0);

            modelBuilder.Entity<Highlights>()
                .Property(e => e.MaxValue)
                .HasPrecision(53, 0);

            modelBuilder.Entity<InputActions>()
                .HasMany(e => e.InputActionDefaultGestures)
                .WithRequired(e => e.InputActions)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InputCategories>()
                .HasMany(e => e.InputActions)
                .WithRequired(e => e.InputCategories)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InputContexts>()
                .HasMany(e => e.InputActions)
                .WithRequired(e => e.InputContexts)
                .WillCascadeOnDelete(false);

            //Come back to this -Z
            //modelBuilder.Entity<Queries>()
            //    .HasMany(e => e.ConfigurationUpdateQueries)
            //    .WithRequired(e => e.Queries);

            modelBuilder.Entity<Queries>()
                .HasMany(e => e.DomainOverrideQueries)
                .WithRequired(e => e.Queries)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Queries>()
                .HasMany(e => e.DomainRangeQueries)
                .WithRequired(e => e.Queries)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Queries>()
                .HasMany(e => e.DomainValueFilterQueries)
                .WithRequired(e => e.Queries)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Queries>()
                .HasMany(e => e.DomainValueQueries)
                .WithRequired(e => e.Queries)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Queries>()
                .HasMany(e => e.DomainValueUnionQueries)
                .WithRequired(e => e.Queries)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Queries>()
                .HasMany(e => e.ParameterQueries)
                .WithRequired(e => e.Queries)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Queries>()
                .HasMany(e => e.QueryCriteria)
                .WithRequired(e => e.Queries)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Queries>()
                .HasMany(e => e.QueryParameters)
                .WithRequired(e => e.Queries)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ReportQueries>()
                .HasMany(e => e.Reports)
                .WithRequired(e => e.ReportQueries)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Reports>()
                .HasMany(e => e.ReportColumns)
                .WithRequired(e => e.Reports)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rulesets>()
                .HasMany(e => e.RulesetTypes)
                .WithRequired(e => e.Rulesets)
                .HasForeignKey(e => e.Ruleset)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StatisticCategories>()
                .HasMany(e => e.Statistics)
                .WithRequired(e => e.StatisticCategories)
                .WillCascadeOnDelete(false);
            #region EF Core Test 1
            //        modelBuilder.Entity<Difficulties_Configuration>()
            //.HasKey(u => new { u.Domain, u.DifficultyType });

            //        modelBuilder.Entity<Eras>()
            //.HasKey(u => new { u.Domain, u.EraType });

            //        modelBuilder.Entity<GameSpeeds>()
            //.HasKey(u => new { u.Domain, u.GameSpeedType });

            //        modelBuilder.Entity<Maps>()
            //.HasKey(u => new { u.Domain, u.File });

            //        modelBuilder.Entity<MapLeaders>()
            //.HasKey(u => new { u.Map, u.LeaderType });

            //        modelBuilder.Entity<MapSizes>()
            //.HasKey(u => new { u.Domain, u.MapSizeType });

            //        modelBuilder.Entity<RulesetTypes>()
            //.HasKey(u => new { u.Ruleset, u.Type });

            //        modelBuilder.Entity<Players>()
            //.HasKey(u => new { u.Domain, u.CivilizationType, u.LeaderType });

            //        modelBuilder.Entity<PlayerItems>()
            //.HasKey(u => new { u.Domain, u.CivilizationType, u.LeaderType, u.Type });

            //        modelBuilder.Entity<DuplicateLeaders>()
            //.HasKey(u => new { u.Domain, u.LeaderType, u.OtherLeaderType });

            //        modelBuilder.Entity<DuplicateCivilizations>()
            //.HasKey(u => new { u.Domain, u.CivilizationType, u.OtherCivilizationType });

            //        modelBuilder.Entity<TurnTimers>()
            //.HasKey(u => new { u.Domain, u.TurnTimerType });

            //        modelBuilder.Entity<TurnPhases>()
            //.HasKey(u => new { u.Domain, u.TurnPhaseType });

            //        modelBuilder.Entity<Victories>()
            //.HasKey(u => new { u.Domain, u.VictoryType });

            //        modelBuilder.Entity<MapDomainOverrides>()
            //.HasKey(u => new { u.Map, u.PlayerId, u.ParameterId, u.Domain });

            //        modelBuilder.Entity<RulesetDomainOverrides>()
            //.HasKey(u => new { u.Ruleset, u.PlayerId, u.ParameterId, u.Domain });

            //        modelBuilder.Entity<MapSupportedValues>()
            //.HasKey(u => new { u.Map, u.PlayerId, u.Domain, u.Value });

            //        modelBuilder.Entity<MapUnSupportedValues>()
            //.HasKey(u => new { u.Map, u.PlayerId, u.Domain, u.Value });

            //        modelBuilder.Entity<RulesetSupportedValues>()
            //.HasKey(u => new { u.Ruleset, u.PlayerId, u.Domain, u.Value });

            //        modelBuilder.Entity<RulesetUnSupportedValues>()
            //.HasKey(u => new { u.Ruleset, u.PlayerId, u.Domain, u.Value });

            //        modelBuilder.Entity<Statistics>()
            //.HasKey(u => new { u.DataPoint, u.Name });

            //        modelBuilder.Entity<Highlights>()
            //.HasKey(u => new { u.DataPoint, u.Name });

            //        modelBuilder.Entity<DataPointAggregateUpdates>()
            //.HasKey(u => new { u.AggregateDataPoint, u.Scope });

            //        modelBuilder.Entity<Graphs>()
            //.HasKey(u => new { u.Graph, u.Scope });

            //        modelBuilder.Entity<ReportColumns>()
            //.HasKey(u => new { u.Report, u.Name });

            //        modelBuilder.Entity<InputActionDefaultGestures>()
            //.HasKey(u => new { u.ActionId, u.Index });

            //        modelBuilder.Entity<QueryCriteria>()
            //.HasKey(u => new { u.QueryId, u.ConfigurationGroup, u.ConfigurationId });

            //        modelBuilder.Entity<QueryParameters>()
            //.HasKey(u => new { u.QueryId, u.Index });

            //        modelBuilder.Entity<ParameterQueryCriteria>()
            //.HasKey(u => new { u.ParameterQueryId, u.ConfigurationGroup, u.ConfigurationId });

            //        modelBuilder.Entity<ParameterQueryDependencies>()
            //.HasKey(u => new { u.ParameterQueryId, u.ConfigurationGroup, u.ConfigurationId });

            //        modelBuilder.Entity<Parameters>()
            //.HasKey(u => new { u.Key1, u.Key2, u.ParameterId });

            //        modelBuilder.Entity<ParameterCriteria>()
            //.HasKey(u => new { u.ParameterId, u.ConfigurationGroup, u.ConfigurationId });

            //        modelBuilder.Entity<ParameterDependencyQueries>()
            //.HasKey(u => new { u.QueryId, u.ParameterIdField, u.ConfigurationGroupField, u.ConfigurationIdField });

            //        modelBuilder.Entity<DomainRangeQueries>()
            //.HasKey(u => new { u.QueryId, u.DomainField });

            //        modelBuilder.Entity<DomainRangeQueries>()
            //.HasKey(u => new { u.QueryId, u.DomainField });

            //        modelBuilder.Entity<DomainOverrideQueries>()
            //.HasKey(u => new { u.QueryId, u.ParameterIdField, u.DomainField });

            //        modelBuilder.Entity<DomainOverrides>()
            //.HasKey(u => new { u.Key1, u.Key2, u.ParameterId });

            //        modelBuilder.Entity<DomainValueQueries>()
            //.HasKey(u => new { u.QueryId, u.DomainField });

            //        modelBuilder.Entity<DomainValues>()
            //.HasKey(u => new { u.Key1, u.Key2, u.Domain, u.Value });

            //        modelBuilder.Entity<DomainValueUnionQueries>()
            //.HasKey(u => new { u.QueryId, u.DomainField, u.OtherDomainField });

            //        modelBuilder.Entity<DomainValueUnions>()
            //.HasKey(u => new { u.Key1, u.Key2, u.Domain, u.OtherDomain });

            //        modelBuilder.Entity<DomainValueFilterQueries>()
            //.HasKey(u => new { u.QueryId, u.DomainField });

            //        modelBuilder.Entity<DomainValueFilters>()
            //.HasKey(u => new { u.Key1, u.Key2, u.Domain, u.Value });

            //        modelBuilder.Entity<ConfigurationUpdates>()
            //.HasKey(u => new { u.Key1, u.Key2, u.SourceGroup, u.SourceId, u.SourceValue, u.TargetGroup, u.TargetId, u.TargetValue });

            //        modelBuilder.Entity<Defeats>()
            //.HasKey(u => new { u.Domain, u.DefeatType });

            //        modelBuilder.Entity<ParameterDependencies>()
            //.HasKey(u => new { u.ParameterId, u.ConfigurationGroup, u.ConfigurationId });
            #endregion EF Core Test 1

            #region EF Core Test 2
            ////EF Core Test 2
            //modelBuilder.Entity<DataPointAggregateScopes>()
            //    .HasMany(e => e.DataPointAggregateUpdates)
            //    .WithOne(e => e.DataPointAggregateScopes)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Highlights>()
            //    .Property(e => e.MinValue);

            //modelBuilder.Entity<Highlights>()
            //    .Property(e => e.MaxValue);

            //modelBuilder.Entity<InputActions>()
            //    .HasMany(e => e.InputActionDefaultGestures)
            //    .WithOne(e => e.InputActions)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<InputCategories>()
            //    .HasMany(e => e.InputActions)
            //    .WithOne(e => e.InputCategories)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<InputContexts>()
            //    .HasMany(e => e.InputActions)
            //    .WithOne(e => e.InputContexts)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Queries>()
            //    .HasOptional(e => e.ConfigurationUpdateQueries)
            //    .WithOne(e => e.Queries);

            //modelBuilder.Entity<Queries>()
            //    .HasMany(e => e.DomainOverrideQueries)
            //    .WithOne(e => e.Queries)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Queries>()
            //    .HasMany(e => e.DomainRangeQueries)
            //    .WithOne(e => e.Queries)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Queries>()
            //    .HasMany(e => e.DomainValueFilterQueries)
            //    .WithOne(e => e.Queries)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Queries>()
            //    .HasMany(e => e.DomainValueQueries)
            //    .WithOne(e => e.Queries)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Queries>()
            //    .HasMany(e => e.DomainValueUnionQueries)
            //    .WithOne(e => e.Queries)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Queries>()
            //    .HasMany(e => e.ParameterQueries)
            //    .WithOne(e => e.Queries)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Queries>()
            //    .HasMany(e => e.QueryCriteria)
            //    .WithOne(e => e.Queries)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Queries>()
            //    .HasMany(e => e.QueryParameters)
            //    .WithOne(e => e.Queries)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<ReportQueries>()
            //    .HasMany(e => e.Reports)
            //    .WithOne(e => e.ReportQueries)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Reports>()
            //    .HasMany(e => e.ReportColumns)
            //    .WithOne(e => e.Reports)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Rulesets>()
            //    .HasMany(e => e.RulesetTypes)
            //    .WithOne(e => e.Rulesets)
            //    .HasForeignKey(e => e.Ruleset)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<StatisticCategories>()
            //    .HasMany(e => e.Statistics)
            //    .WithOne(e => e.StatisticCategories)
            //    .OnDelete(DeleteBehavior.Restrict);
            #endregion EF Core Test 2
            #endregion Model Auto-Created
        }
    }
}
