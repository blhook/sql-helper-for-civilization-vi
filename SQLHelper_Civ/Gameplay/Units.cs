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

    public partial class Units
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Units()
        {
            BonusMinorStartingUnits = new HashSet<BonusMinorStartingUnits>();
            Boosts = new HashSet<Boosts>();
            Boosts1 = new HashSet<Boosts>();
            District_BuildChargeProductions = new HashSet<District_BuildChargeProductions>();
            GreatPersonClasses = new HashSet<GreatPersonClasses>();
            MajorStartingUnits = new HashSet<MajorStartingUnits>();
            Technologies = new HashSet<Technologies>();
            Unit_BuildingPrereqs = new HashSet<Unit_BuildingPrereqs>();
            Improvement_ValidBuildUnits = new HashSet<Improvement_ValidBuildUnits>();
            Route_ValidBuildUnits = new HashSet<Route_ValidBuildUnits>();
            UnitAiInfos = new HashSet<UnitAiInfos>();
            UnitCaptures1 = new HashSet<UnitCaptures>();
            UnitCaptures2 = new HashSet<UnitCaptures>();
            //Units3 = new HashSet<Units>();
            //Units4 = new HashSet<Units>();
        }

        [Key]
        [StringLength(2147483647)]
        public string UnitType { get; set; }

        [Required]
        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Name { get; set; }

        public long BaseSightRange { get; set; }

        public long BaseMoves { get; set; }

        public long Combat { get; set; }

        public long RangedCombat { get; set; }

        public long Range { get; set; }

        public long Bombard { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Domain { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string FormationClass { get; set; }

        public long Cost { get; set; }

        public long? PopulationCost { get; set; }

        public bool FoundCity { get; set; }

        public bool FoundReligion { get; set; }

        public bool MakeTradeRoute { get; set; }

        public bool EvangelizeBelief { get; set; }

        public bool LaunchInquisition { get; set; }

        public bool RequiresInquisition { get; set; }

        public long BuildCharges { get; set; }

        public long ReligiousStrength { get; set; }

        public long ReligionEvictPercent { get; set; }

        public long SpreadCharges { get; set; }

        public long ReligiousHealCharges { get; set; }

        public bool ExtractsArtifacts { get; set; }

        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Description { get; set; }

        [StringLength(2147483647)]
        public string Flavor { get; set; }

        public bool CanCapture { get; set; }

        public bool CanRetreatWhenCaptured { get; set; }

        [StringLength(2147483647)]
        public string TraitType { get; set; }

        public bool AllowBarbarians { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string CostProgressionModel { get; set; }

        public long CostProgressionParam1 { get; set; }

        [StringLength(2147483647)]
        public string PromotionClass { get; set; }

        public long InitialLevel { get; set; }

        public long NumRandomChoices { get; set; }

        [StringLength(2147483647)]
        public string PrereqTech { get; set; }

        [StringLength(2147483647)]
        public string PrereqCivic { get; set; }

        [StringLength(2147483647)]
        public string PrereqDistrict { get; set; }

        public long? PrereqPopulation { get; set; }

        [StringLength(2147483647)]
        public string LeaderType { get; set; }

        public bool CanTrain { get; set; }

        [StringLength(2147483647)]
        public string StrategicResource { get; set; }

        [StringLength(2147483647)]
        public string PurchaseYield { get; set; }

        public bool MustPurchase { get; set; }

        public long Maintenance { get; set; }

        public bool Stackable { get; set; }

        public long AirSlots { get; set; }

        public bool CanTargetAir { get; set; }

        [StringLength(2147483647)]
        public string PseudoYieldType { get; set; }

        public bool ZoneOfControl { get; set; }

        public long AntiAirCombat { get; set; }

        public bool Spy { get; set; }

        public bool WMDCapable { get; set; }

        public long ParkCharges { get; set; }

        public bool IgnoreMoves { get; set; }

        public bool TeamVisibility { get; set; }

        [StringLength(2147483647)]
        public string ObsoleteTech { get; set; }

        [StringLength(2147483647)]
        public string ObsoleteCivic { get; set; }

        [StringLength(2147483647)]
        public string MandatoryObsoleteTech { get; set; }

        [StringLength(2147483647)]
        public string MandatoryObsoleteCivic { get; set; }

        [StringLength(2147483647)]
        public string AdvisorType { get; set; }

        public bool EnabledByReligion { get; set; }

        public bool TrackReligion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BonusMinorStartingUnits> BonusMinorStartingUnits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Boosts> Boosts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Boosts> Boosts1 { get; set; }

        public virtual Civics Civics { get; set; }

        public virtual Civics Civics1 { get; set; }

        public virtual Civics Civics2 { get; set; }

        public virtual Civics Civics3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<District_BuildChargeProductions> District_BuildChargeProductions { get; set; }

        public virtual Districts Districts { get; set; }

        public virtual Flavors Flavors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GreatPersonClasses> GreatPersonClasses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MajorStartingUnits> MajorStartingUnits { get; set; }

        public virtual PseudoYields PseudoYields { get; set; }

        public virtual Resources Resources { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Technologies> Technologies { get; set; }

        public virtual Technologies Technologies1 { get; set; }

        public virtual Technologies Technologies2 { get; set; }

        public virtual Technologies Technologies3 { get; set; }

        public virtual Traits Traits { get; set; }

        public virtual Types Types { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Unit_BuildingPrereqs> Unit_BuildingPrereqs { get; set; }

        public virtual UnitPromotionClasses UnitPromotionClasses { get; set; }

        public virtual Yields Yields { get; set; }

        public virtual Yields Yields1 { get; set; }

        public virtual Units_XP2 Units_XP2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Improvement_ValidBuildUnits> Improvement_ValidBuildUnits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Route_ValidBuildUnits> Route_ValidBuildUnits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UnitAiInfos> UnitAiInfos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [InverseProperty(nameof(UnitCaptures.BecomesUnitTypeNavigation))]
        public virtual ICollection<UnitCaptures> UnitCaptures1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [InverseProperty(nameof(UnitCaptures.CapturedUnitTypeNavigation))]
        public virtual ICollection<UnitCaptures> UnitCaptures2 { get; set; }

        ////Seems like auto map failure for these 4. Likely based off the joining tables. 
        //public virtual Units Units11 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Units> Units3 { get; set; }

        //public virtual Units Units12 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Units> Units4 { get; set; }
    }
}
