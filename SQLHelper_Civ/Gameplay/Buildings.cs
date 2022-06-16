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

    public partial class Buildings
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Buildings()
        {
            Boosts = new HashSet<Boosts>();
            Building_GreatPersonPoints = new HashSet<Building_GreatPersonPoints>();
            Building_GreatWorks = new HashSet<Building_GreatWorks>();
            Building_ResourceCosts = new HashSet<Building_ResourceCosts>();
            Building_YieldChanges = new HashSet<Building_YieldChanges>();
            Building_YieldChangesBonusWithPower = new HashSet<Building_YieldChangesBonusWithPower>();
            Building_YieldDistrictCopies = new HashSet<Building_YieldDistrictCopies>();
            Building_YieldsPerEra = new HashSet<Building_YieldsPerEra>();
            BuildingModifiers = new HashSet<BuildingModifiers>();
            EmergencyScoreSources = new HashSet<EmergencyScoreSources>();
            GreatPersonIndividuals = new HashSet<GreatPersonIndividuals>();
            Project_BuildingCosts = new HashSet<Project_BuildingCosts>();
            Projects = new HashSet<Projects>();
            Projects_XP2 = new HashSet<Projects_XP2>();
            Projects_XP21 = new HashSet<Projects_XP2>();
            StartingBuildings = new HashSet<StartingBuildings>();
            Unit_BuildingPrereqs = new HashSet<Unit_BuildingPrereqs>();
            Building_RequiredFeatures = new HashSet<Building_RequiredFeatures>();
            Building_ValidFeatures = new HashSet<Building_ValidFeatures>();
            Building_ValidTerrains = new HashSet<Building_ValidTerrains>();
            BuildingPrereqs1 = new HashSet<BuildingPrereqs>();
            BuildingPrereqs2 = new HashSet<BuildingPrereqs>();
            BuildingReplaces1 = new HashSet<BuildingReplaces>();
            BuildingReplaces2 = new HashSet<BuildingReplaces>();
            MutuallyExclusiveBuildings1 = new HashSet<MutuallyExclusiveBuildings>();
            MutuallyExclusiveBuildings2 = new HashSet<MutuallyExclusiveBuildings>();
        }

        [Key]
        [StringLength(2147483647)]
        public string BuildingType { get; set; }

        [Required]
        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Name { get; set; }

        [StringLength(2147483647)]
        public string PrereqTech { get; set; }

        [StringLength(2147483647)]
        public string PrereqCivic { get; set; }

        public long Cost { get; set; }

        public long MaxPlayerInstances { get; set; }

        public long MaxWorldInstances { get; set; }

        public bool Capital { get; set; }

        [StringLength(2147483647)]
        public string PrereqDistrict { get; set; }

        [StringLength(2147483647)]
        public string AdjacentDistrict { get; set; }

        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Description { get; set; }

        public bool RequiresPlacement { get; set; }

        public bool RequiresRiver { get; set; }

        public long? OuterDefenseHitPoints { get; set; }

        public long Housing { get; set; }

        public long Entertainment { get; set; }

        [StringLength(2147483647)]
        public string AdjacentResource { get; set; }

        public bool? Coast { get; set; }

        public bool EnabledByReligion { get; set; }

        public bool AllowsHolyCity { get; set; }

        [StringLength(2147483647)]
        public string PurchaseYield { get; set; }

        public bool MustPurchase { get; set; }

        public long Maintenance { get; set; }

        public bool IsWonder { get; set; }

        [StringLength(2147483647)]
        public string TraitType { get; set; }

        public long OuterDefenseStrength { get; set; }

        public long? CitizenSlots { get; set; }

        public bool MustBeLake { get; set; }

        public bool MustNotBeLake { get; set; }

        public long RegionalRange { get; set; }

        public bool AdjacentToMountain { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string ObsoleteEra { get; set; }

        public bool RequiresReligion { get; set; }

        public long GrantFortification { get; set; }

        public long DefenseModifier { get; set; }

        public bool InternalOnly { get; set; }

        public bool RequiresAdjacentRiver { get; set; }

        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Quote { get; set; }

        [StringLength(2147483647)]
        public string QuoteAudio { get; set; }

        public bool MustBeAdjacentLand { get; set; }

        [StringLength(2147483647)]
        public string AdvisorType { get; set; }

        public bool AdjacentCapital { get; set; }

        [StringLength(2147483647)]
        public string AdjacentImprovement { get; set; }

        [StringLength(2147483647)]
        public string CityAdjacentTerrain { get; set; }

        public bool? UnlocksGovernmentPolicy { get; set; }

        [StringLength(2147483647)]
        public string GovernmentTierRequirement { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Boosts> Boosts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Building_GreatPersonPoints> Building_GreatPersonPoints { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Building_GreatWorks> Building_GreatWorks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Building_ResourceCosts> Building_ResourceCosts { get; set; }

        public virtual Building_TourismBombs_XP2 Building_TourismBombs_XP2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Building_YieldChanges> Building_YieldChanges { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Building_YieldChangesBonusWithPower> Building_YieldChangesBonusWithPower { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Building_YieldDistrictCopies> Building_YieldDistrictCopies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Building_YieldsPerEra> Building_YieldsPerEra { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BuildingModifiers> BuildingModifiers { get; set; }

        public virtual Terrains Terrains { get; set; }

        public virtual Improvements Improvements { get; set; }

        public virtual Types Types { get; set; }

        public virtual Traits Traits { get; set; }

        public virtual Yields Yields { get; set; }

        public virtual Civics Civics { get; set; }

        public virtual Resources Resources { get; set; }

        public virtual Technologies Technologies { get; set; }

        public virtual Districts Districts { get; set; }

        public virtual Districts Districts1 { get; set; }

        public virtual Buildings_XP2 Buildings_XP2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmergencyScoreSources> EmergencyScoreSources { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GreatPersonIndividuals> GreatPersonIndividuals { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Project_BuildingCosts> Project_BuildingCosts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Projects> Projects { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Projects_XP2> Projects_XP2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Projects_XP2> Projects_XP21 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StartingBuildings> StartingBuildings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Unit_BuildingPrereqs> Unit_BuildingPrereqs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Building_RequiredFeatures> Building_RequiredFeatures { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Building_ValidFeatures> Building_ValidFeatures { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Building_ValidTerrains> Building_ValidTerrains { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [InverseProperty(nameof(BuildingPrereqs.PrereqBuildingNavigation))]
        public virtual ICollection<BuildingPrereqs> BuildingPrereqs1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [InverseProperty(nameof(BuildingPrereqs.BuildingNavigation))]
        public virtual ICollection<BuildingPrereqs> BuildingPrereqs2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [InverseProperty(nameof(BuildingReplaces.CivUniqueBuildingTypeNavigation))]
        public virtual ICollection<BuildingReplaces> BuildingReplaces1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [InverseProperty(nameof(BuildingReplaces.ReplacesBuildingTypeNavigation))]
        public virtual ICollection<BuildingReplaces> BuildingReplaces2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [InverseProperty(nameof(MutuallyExclusiveBuildings.BuildingNavigation))]
        public virtual ICollection<MutuallyExclusiveBuildings> MutuallyExclusiveBuildings1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [InverseProperty(nameof(MutuallyExclusiveBuildings.MutuallyExclusiveBuildingNavigation))]
        public virtual ICollection<MutuallyExclusiveBuildings> MutuallyExclusiveBuildings2 { get; set; }
    }
}
