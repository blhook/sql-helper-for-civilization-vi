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

    public partial class Resources
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Resources()
        {
            BarbarianTribes = new HashSet<BarbarianTribes>();
            Boosts = new HashSet<Boosts>();
            Building_ResourceCosts = new HashSet<Building_ResourceCosts>();
            Buildings = new HashSet<Buildings>();
            Buildings_XP2 = new HashSet<Buildings_XP2>();
            Improvement_ValidResources = new HashSet<Improvement_ValidResources>();
            Project_ResourceCosts = new HashSet<Project_ResourceCosts>();
            Projects = new HashSet<Projects>();
            Resource_Harvests = new HashSet<Resource_Harvests>();
            Resource_TradeRouteYields = new HashSet<Resource_TradeRouteYields>();
            Resource_YieldChanges = new HashSet<Resource_YieldChanges>();
            Route_ResourceCosts = new HashSet<Route_ResourceCosts>();
            StartBiasResources = new HashSet<StartBiasResources>();
            Units = new HashSet<Units>();
            Units_XP2 = new HashSet<Units_XP2>();
            Improvement_ValidAdjacentResources = new HashSet<Improvement_ValidAdjacentResources>();
            Resource_ValidFeatures = new HashSet<Resource_ValidFeatures>();
            Resource_ValidTerrains = new HashSet<Resource_ValidTerrains>();
        }

        [Key]
        [StringLength(2147483647)]
        public string ResourceType { get; set; }

        [Required]
        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Name { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string ResourceClassType { get; set; }

        public long Happiness { get; set; }

        public bool NoRiver { get; set; }

        public bool RequiresRiver { get; set; }

        public long Frequency { get; set; }

        public bool Clumped { get; set; }

        [StringLength(2147483647)]
        public string PrereqTech { get; set; }

        [StringLength(2147483647)]
        public string PrereqCivic { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string PeakEra { get; set; }

        public long RevealedEra { get; set; }

        public bool LakeEligible { get; set; }

        public bool AdjacentToLand { get; set; }

        public long SeaFrequency { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BarbarianTribes> BarbarianTribes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Boosts> Boosts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Building_ResourceCosts> Building_ResourceCosts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Buildings> Buildings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Buildings_XP2> Buildings_XP2 { get; set; }

        public virtual Civics Civics { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Improvement_ValidResources> Improvement_ValidResources { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Project_ResourceCosts> Project_ResourceCosts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Projects> Projects { get; set; }

        public virtual Resource_Consumption Resource_Consumption { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Resource_Harvests> Resource_Harvests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Resource_TradeRouteYields> Resource_TradeRouteYields { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Resource_YieldChanges> Resource_YieldChanges { get; set; }

        public virtual Types Types { get; set; }

        public virtual Technologies Technologies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Route_ResourceCosts> Route_ResourceCosts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StartBiasResources> StartBiasResources { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Units> Units { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Units_XP2> Units_XP2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Improvement_ValidAdjacentResources> Improvement_ValidAdjacentResources { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Resource_ValidFeatures> Resource_ValidFeatures { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Resource_ValidTerrains> Resource_ValidTerrains { get; set; }
    }
}
