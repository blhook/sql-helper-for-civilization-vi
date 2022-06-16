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

    public partial class Districts
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Districts()
        {
            Adjacency_YieldChanges = new HashSet<Adjacency_YieldChanges>();
            AppealHousingChanges = new HashSet<AppealHousingChanges>();
            Boosts = new HashSet<Boosts>();
            Buildings = new HashSet<Buildings>();
            Buildings1 = new HashSet<Buildings>();
            District_BuildChargeProductions = new HashSet<District_BuildChargeProductions>();
            District_CitizenGreatPersonPoints = new HashSet<District_CitizenGreatPersonPoints>();
            District_CitizenYieldChanges = new HashSet<District_CitizenYieldChanges>();
            District_GreatPersonPoints = new HashSet<District_GreatPersonPoints>();
            District_TradeRouteYields = new HashSet<District_TradeRouteYields>();
            EmergencyScoreSources = new HashSet<EmergencyScoreSources>();
            GreatPersonClasses = new HashSet<GreatPersonClasses>();
            GreatPersonIndividuals = new HashSet<GreatPersonIndividuals>();
            MajorStartingUnits = new HashSet<MajorStartingUnits>();
            Projects = new HashSet<Projects>();
            StartingBuildings = new HashSet<StartingBuildings>();
            UnitOperations = new HashSet<UnitOperations>();
            Units = new HashSet<Units>();
            District_Adjacencies = new HashSet<District_Adjacencies>();
            District_RequiredFeatures = new HashSet<District_RequiredFeatures>();
            District_ValidTerrains = new HashSet<District_ValidTerrains>();
            DistrictModifiers = new HashSet<DistrictModifiers>();
            //Districts1 = new HashSet<Districts>();
            ExcludedDistricts = new HashSet<ExcludedDistricts>();
            MutuallyExclusiveDistricts1 = new HashSet<MutuallyExclusiveDistricts>();
            MutuallyExclusiveDistricts2 = new HashSet<MutuallyExclusiveDistricts>();
            //Districts_XP2 = new HashSet<Districts_XP2>();
        }

        [Key]
        [StringLength(2147483647)]
        public string DistrictType { get; set; }

        [Required]
        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Name { get; set; }

        [StringLength(2147483647)]
        public string PrereqTech { get; set; }

        [StringLength(2147483647)]
        public string PrereqCivic { get; set; }

        public bool Coast { get; set; }

        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Description { get; set; }

        public long Cost { get; set; }

        public bool RequiresPlacement { get; set; }

        public bool RequiresPopulation { get; set; }

        public bool NoAdjacentCity { get; set; }

        public bool CityCenter { get; set; }

        public bool Aqueduct { get; set; }

        public bool InternalOnly { get; set; }

        public bool? ZOC { get; set; }

        public bool FreeEmbark { get; set; }

        public long? HitPoints { get; set; }

        public bool CaptureRemovesBuildings { get; set; }

        public bool CaptureRemovesCityDefenses { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string PlunderType { get; set; }

        public long PlunderAmount { get; set; }

        public bool TradeEmbark { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string MilitaryDomain { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string CostProgressionModel { get; set; }

        public long CostProgressionParam1 { get; set; }

        [StringLength(2147483647)]
        public string TraitType { get; set; }

        public long Appeal { get; set; }

        public long Housing { get; set; }

        public long Entertainment { get; set; }

        public bool OnePerCity { get; set; }

        public bool AllowsHolyCity { get; set; }

        public long Maintenance { get; set; }

        public long AirSlots { get; set; }

        public long? CitizenSlots { get; set; }

        public long TravelTime { get; set; }

        public long CityStrengthModifier { get; set; }

        public bool AdjacentToLand { get; set; }

        public bool CanAttack { get; set; }

        [StringLength(2147483647)]
        public string AdvisorType { get; set; }

        public bool CaptureRemovesDistrict { get; set; }

        [Column(TypeName = "real")]
        public double MaxPerPlayer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Adjacency_YieldChanges> Adjacency_YieldChanges { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AppealHousingChanges> AppealHousingChanges { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Boosts> Boosts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Buildings> Buildings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Buildings> Buildings1 { get; set; }

        public virtual Civics Civics { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<District_BuildChargeProductions> District_BuildChargeProductions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<District_CitizenGreatPersonPoints> District_CitizenGreatPersonPoints { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<District_CitizenYieldChanges> District_CitizenYieldChanges { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<District_GreatPersonPoints> District_GreatPersonPoints { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<District_TradeRouteYields> District_TradeRouteYields { get; set; }

        public virtual Types Types { get; set; }

        public virtual Traits Traits { get; set; }

        public virtual Technologies Technologies { get; set; }

        /// <summary>
        /// Come back to this. -Z
        /// </summary>
        //public virtual ICollection<Districts_XP2> Districts_XP2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmergencyScoreSources> EmergencyScoreSources { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GreatPersonClasses> GreatPersonClasses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GreatPersonIndividuals> GreatPersonIndividuals { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MajorStartingUnits> MajorStartingUnits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Projects> Projects { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StartingBuildings> StartingBuildings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UnitOperations> UnitOperations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Units> Units { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<District_Adjacencies> District_Adjacencies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<District_RequiredFeatures> District_RequiredFeatures { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<District_ValidTerrains> District_ValidTerrains { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DistrictModifiers> DistrictModifiers { get; set; }

        ////Seems like auto map failure for these two. Likely based off the joining tables. 
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Districts> Districts1 { get; set; }

        //public virtual Districts Districts2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExcludedDistricts> ExcludedDistricts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [InverseProperty(nameof(MutuallyExclusiveDistricts.DistrictNavigation))]
        public virtual ICollection<MutuallyExclusiveDistricts> MutuallyExclusiveDistricts1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [InverseProperty(nameof(MutuallyExclusiveDistricts.MutuallyExclusiveDistrictNavigation))]
        public virtual ICollection<MutuallyExclusiveDistricts> MutuallyExclusiveDistricts2 { get; set; }
    }
}
