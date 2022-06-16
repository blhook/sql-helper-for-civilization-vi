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
    using Test.ORM.Localization;
    using static SQLHelper_Civ.Extensions_Helpers.Classes;

    public partial class Improvements
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Improvements()
        {
            Adjacency_YieldChanges = new HashSet<Adjacency_YieldChanges>();
            Boosts = new HashSet<Boosts>();
            Buildings = new HashSet<Buildings>();
            GoodyHuts = new HashSet<GoodyHuts>();
            Improvement_BonusYieldChanges = new HashSet<Improvement_BonusYieldChanges>();
            Improvement_ValidResources = new HashSet<Improvement_ValidResources>();
            Improvement_ValidTerrains = new HashSet<Improvement_ValidTerrains>();
            Improvement_YieldChanges = new HashSet<Improvement_YieldChanges>();
            ImprovementModifiers = new HashSet<ImprovementModifiers>();
            Improvement_Adjacencies = new HashSet<Improvement_Adjacencies>();
            Improvement_InvalidAdjacentFeatures = new HashSet<Improvement_InvalidAdjacentFeatures>();
            Improvement_ValidAdjacentResources = new HashSet<Improvement_ValidAdjacentResources>();
            Improvement_ValidAdjacentTerrains = new HashSet<Improvement_ValidAdjacentTerrains>();
            Improvement_ValidBuildUnits = new HashSet<Improvement_ValidBuildUnits>();
            Improvement_ValidFeatures = new HashSet<Improvement_ValidFeatures>();
            RandomEvent_PillagedImprovements = new HashSet<RandomEvent_PillagedImprovements>();
        }

        [Key]
        [StringLength(2147483647)]
        public string ImprovementType { get; set; }

        [Required]
        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Name { get; set; }

        public bool BarbarianCamp { get; set; }

        [StringLength(2147483647)]
        public string PrereqTech { get; set; }

        [StringLength(2147483647)]
        public string PrereqCivic { get; set; }

        public bool Buildable { get; set; }

        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Description { get; set; }

        public bool RemoveOnEntry { get; set; }

        public long DispersalGold { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string PlunderType { get; set; }

        public long PlunderAmount { get; set; }

        public bool Goody { get; set; }

        public long? TilesPerGoody { get; set; }

        public long? GoodyRange { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Icon { get; set; }

        [StringLength(2147483647)]
        public string TraitType { get; set; }

        public long Housing { get; set; }

        public long TilesRequired { get; set; }

        public bool SameAdjacentValid { get; set; }

        public long RequiresRiver { get; set; }

        public bool EnforceTerrain { get; set; }

        public bool BuildInLine { get; set; }

        public bool CanBuildOutsideTerritory { get; set; }

        public bool BuildOnFrontier { get; set; }

        public long AirSlots { get; set; }

        public long DefenseModifier { get; set; }

        public long GrantFortification { get; set; }

        public long? MinimumAppeal { get; set; }

        public bool Coast { get; set; }

        [StringLength(2147483647)]
        public string YieldFromAppeal { get; set; }

        public long WeaponSlots { get; set; }

        public long ReligiousUnitHealRate { get; set; }

        public long Appeal { get; set; }

        public bool OnePerCity { get; set; }

        public long YieldFromAppealPercent { get; set; }

        public long ValidAdjacentTerrainAmount { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Domain { get; set; }

        public bool AdjacentSeaResource { get; set; }

        public bool RequiresAdjacentBonusOrLuxury { get; set; }

        public long MovementChange { get; set; }

        public bool Workable { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Adjacency_YieldChanges> Adjacency_YieldChanges { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Boosts> Boosts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Buildings> Buildings { get; set; }

        public virtual Civics Civics { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoodyHuts> GoodyHuts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Improvement_BonusYieldChanges> Improvement_BonusYieldChanges { get; set; }

        public virtual Improvement_Tourism Improvement_Tourism { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Improvement_ValidResources> Improvement_ValidResources { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Improvement_ValidTerrains> Improvement_ValidTerrains { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Improvement_YieldChanges> Improvement_YieldChanges { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImprovementModifiers> ImprovementModifiers { get; set; }

        public virtual Types Types { get; set; }

        public virtual Yields Yields { get; set; }

        public virtual Traits Traits { get; set; }

        public virtual Technologies Technologies { get; set; }

        public virtual Improvements_XP2 Improvements_XP2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Improvement_Adjacencies> Improvement_Adjacencies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Improvement_InvalidAdjacentFeatures> Improvement_InvalidAdjacentFeatures { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Improvement_ValidAdjacentResources> Improvement_ValidAdjacentResources { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Improvement_ValidAdjacentTerrains> Improvement_ValidAdjacentTerrains { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Improvement_ValidBuildUnits> Improvement_ValidBuildUnits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Improvement_ValidFeatures> Improvement_ValidFeatures { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RandomEvent_PillagedImprovements> RandomEvent_PillagedImprovements { get; set; }
    }
}
