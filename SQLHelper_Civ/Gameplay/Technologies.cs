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

    public partial class Technologies
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Technologies()
        {
            Adjacency_YieldChanges = new HashSet<Adjacency_YieldChanges>();
            Adjacency_YieldChanges1 = new HashSet<Adjacency_YieldChanges>();
            Boosts = new HashSet<Boosts>();
            Boosts1 = new HashSet<Boosts>();
            Buildings = new HashSet<Buildings>();
            DiplomaticActions = new HashSet<DiplomaticActions>();
            DiplomaticActions1 = new HashSet<DiplomaticActions>();
            DiplomaticVisibilitySources = new HashSet<DiplomaticVisibilitySources>();
            Districts = new HashSet<Districts>();
            Features = new HashSet<Features>();
            Improvement_BonusYieldChanges = new HashSet<Improvement_BonusYieldChanges>();
            Improvement_Tourism = new HashSet<Improvement_Tourism>();
            Improvement_ValidTerrains = new HashSet<Improvement_ValidTerrains>();
            Improvements = new HashSet<Improvements>();
            Policies = new HashSet<Policies>();
            Projects = new HashSet<Projects>();
            Resource_Consumption = new HashSet<Resource_Consumption>();
            Resource_Harvests = new HashSet<Resource_Harvests>();
            Resources = new HashSet<Resources>();
            Routes_XP2 = new HashSet<Routes_XP2>();
            TechnologyModifiers = new HashSet<TechnologyModifiers>();
            TechnologyQuotes = new HashSet<TechnologyQuotes>();
            TechnologyRandomCosts = new HashSet<TechnologyRandomCosts>();
            UnitCommands = new HashSet<UnitCommands>();
            UnitOperations = new HashSet<UnitOperations>();
            Units1 = new HashSet<Units>();
            Units2 = new HashSet<Units>();
            Units3 = new HashSet<Units>();
            StartingBoostedTechnologies = new HashSet<StartingBoostedTechnologies>();
            TechnologyPrereqs1 = new HashSet<TechnologyPrereqs>();
            TechnologyPrereqs2 = new HashSet<TechnologyPrereqs>();
        }

        [Key]
        [StringLength(2147483647)]
        public string TechnologyType { get; set; }

        [Required]
        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Name { get; set; }

        public long Cost { get; set; }

        public bool Repeatable { get; set; }

        [StringLength(2147483647)]
        public string EmbarkUnitType { get; set; }

        public bool EmbarkAll { get; set; }

        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Description { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string EraType { get; set; }

        public bool Critical { get; set; }

        public bool BarbarianFree { get; set; }

        public long? UITreeRow { get; set; }

        [StringLength(2147483647)]
        public string AdvisorType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Adjacency_YieldChanges> Adjacency_YieldChanges { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Adjacency_YieldChanges> Adjacency_YieldChanges1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Boosts> Boosts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Boosts> Boosts1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Buildings> Buildings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiplomaticActions> DiplomaticActions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiplomaticActions> DiplomaticActions1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiplomaticVisibilitySources> DiplomaticVisibilitySources { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Districts> Districts { get; set; }

        public virtual Eras Eras { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Features> Features { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Improvement_BonusYieldChanges> Improvement_BonusYieldChanges { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Improvement_Tourism> Improvement_Tourism { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Improvement_ValidTerrains> Improvement_ValidTerrains { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Improvements> Improvements { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Policies> Policies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Projects> Projects { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Resource_Consumption> Resource_Consumption { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Resource_Harvests> Resource_Harvests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Resources> Resources { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Routes_XP2> Routes_XP2 { get; set; }

        public virtual Types Types { get; set; }

        public virtual Units Units { get; set; }

        public virtual Technologies_XP2 Technologies_XP2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TechnologyModifiers> TechnologyModifiers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TechnologyQuotes> TechnologyQuotes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TechnologyRandomCosts> TechnologyRandomCosts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UnitCommands> UnitCommands { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UnitOperations> UnitOperations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Units> Units1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Units> Units2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Units> Units3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StartingBoostedTechnologies> StartingBoostedTechnologies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [InverseProperty(nameof(TechnologyPrereqs.PrereqTechNavigation))]
        public virtual ICollection<TechnologyPrereqs> TechnologyPrereqs1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [InverseProperty(nameof(TechnologyPrereqs.TechnologyNavigation))]
        public virtual ICollection<TechnologyPrereqs> TechnologyPrereqs2 { get; set; }
    }
}
