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

namespace Test.ORM.Gameplay
{
    using SQLHelper_Civ.Globals;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Test.ORM.Localization;
    using static SQLHelper_Civ.Extensions_Helpers.Classes;

    public partial class Yields
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Yields()
        {
            Adjacency_YieldChanges = new HashSet<Adjacency_YieldChanges>();
            AiBuildSpecializations = new HashSet<AiBuildSpecializations>();
            AiBuildSpecializations1 = new HashSet<AiBuildSpecializations>();
            Building_YieldChanges = new HashSet<Building_YieldChanges>();
            Building_YieldChangesBonusWithPower = new HashSet<Building_YieldChangesBonusWithPower>();
            Building_YieldDistrictCopies = new HashSet<Building_YieldDistrictCopies>();
            Building_YieldDistrictCopies1 = new HashSet<Building_YieldDistrictCopies>();
            Building_YieldsPerEra = new HashSet<Building_YieldsPerEra>();
            Buildings = new HashSet<Buildings>();
            CongressAiChanges = new HashSet<CongressAiChanges>();
            District_CitizenYieldChanges = new HashSet<District_CitizenYieldChanges>();
            District_TradeRouteYields = new HashSet<District_TradeRouteYields>();
            Feature_AdjacentYields = new HashSet<Feature_AdjacentYields>();
            Feature_Removes = new HashSet<Feature_Removes>();
            Feature_YieldChanges = new HashSet<Feature_YieldChanges>();
            GreatWork_YieldChanges = new HashSet<GreatWork_YieldChanges>();
            Improvement_BonusYieldChanges = new HashSet<Improvement_BonusYieldChanges>();
            Improvement_YieldChanges = new HashSet<Improvement_YieldChanges>();
            Improvements = new HashSet<Improvements>();
            Project_YieldConversions = new HashSet<Project_YieldConversions>();
            RandomEvent_Yields = new HashSet<RandomEvent_Yields>();
            Resource_Harvests = new HashSet<Resource_Harvests>();
            Resource_TradeRouteYields = new HashSet<Resource_TradeRouteYields>();
            Resource_YieldChanges = new HashSet<Resource_YieldChanges>();
            Strategy_YieldPriorities = new HashSet<Strategy_YieldPriorities>();
            Terrain_YieldChanges = new HashSet<Terrain_YieldChanges>();
            Units = new HashSet<Units>();
            Units1 = new HashSet<Units>();
        }

        [Key]
        [StringLength(2147483647)]
        public string YieldType { get; set; }

        [Required]
        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Name { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string IconString { get; set; }

        [Column(TypeName = "real")]
        public double OccupiedCityChange { get; set; }

        [Column(TypeName = "real")]
        public double DefaultValue { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Adjacency_YieldChanges> Adjacency_YieldChanges { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AiBuildSpecializations> AiBuildSpecializations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AiBuildSpecializations> AiBuildSpecializations1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Building_YieldChanges> Building_YieldChanges { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Building_YieldChangesBonusWithPower> Building_YieldChangesBonusWithPower { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Building_YieldDistrictCopies> Building_YieldDistrictCopies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Building_YieldDistrictCopies> Building_YieldDistrictCopies1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Building_YieldsPerEra> Building_YieldsPerEra { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Buildings> Buildings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CongressAiChanges> CongressAiChanges { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<District_CitizenYieldChanges> District_CitizenYieldChanges { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<District_TradeRouteYields> District_TradeRouteYields { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Feature_AdjacentYields> Feature_AdjacentYields { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Feature_Removes> Feature_Removes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Feature_YieldChanges> Feature_YieldChanges { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GreatWork_YieldChanges> GreatWork_YieldChanges { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Improvement_BonusYieldChanges> Improvement_BonusYieldChanges { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Improvement_YieldChanges> Improvement_YieldChanges { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Improvements> Improvements { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Project_YieldConversions> Project_YieldConversions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RandomEvent_Yields> RandomEvent_Yields { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Resource_Harvests> Resource_Harvests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Resource_TradeRouteYields> Resource_TradeRouteYields { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Resource_YieldChanges> Resource_YieldChanges { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Strategy_YieldPriorities> Strategy_YieldPriorities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Terrain_YieldChanges> Terrain_YieldChanges { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Units> Units { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Units> Units1 { get; set; }
    }
}
