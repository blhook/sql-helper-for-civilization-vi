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

    public partial class Eras
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Eras()
        {
            BonusMinorStartingUnits = new HashSet<BonusMinorStartingUnits>();
            Civics = new HashSet<Civics>();
            CommemorationTypes = new HashSet<CommemorationTypes>();
            CommemorationTypes1 = new HashSet<CommemorationTypes>();
            GreatPersonIndividuals = new HashSet<GreatPersonIndividuals>();
            GreatWorks = new HashSet<GreatWorks>();
            MajorStartingUnits = new HashSet<MajorStartingUnits>();
            Moments = new HashSet<Moments>();
            Moments1 = new HashSet<Moments>();
            Moments2 = new HashSet<Moments>();
            Policies_XP1 = new HashSet<Policies_XP1>();
            Policies_XP11 = new HashSet<Policies_XP1>();
            Routes = new HashSet<Routes>();
            StartingBuildings = new HashSet<StartingBuildings>();
            StartingGovernments = new HashSet<StartingGovernments>();
            Technologies = new HashSet<Technologies>();
            RandomAgendaEraTags = new HashSet<RandomAgendaEraTags>();
            StartingBoostedCivics = new HashSet<StartingBoostedCivics>();
            StartingBoostedTechnologies = new HashSet<StartingBoostedTechnologies>();
            StartingCivics = new HashSet<StartingCivics>();
        }

        [Key]
        [StringLength(2147483647)]
        public string EraType { get; set; }

        [Required]
        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Name { get; set; }

        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Description { get; set; }

        public long ChronologyIndex { get; set; }

        public long WarmongerPoints { get; set; }

        public long GreatPersonBaseCost { get; set; }

        [StringLength(2147483647)]
        public string EraTechBackgroundTexture { get; set; }

        [StringLength(2147483647)]
        public string EraCivicBackgroundTexture { get; set; }

        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string WarmongerLevelDescription { get; set; }

        public long EmbarkedUnitStrength { get; set; }

        public long EraTechBackgroundTextureOffsetX { get; set; }

        public long EraCivicBackgroundTextureOffsetX { get; set; }

        public string TechTreeLayoutMethod { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BonusMinorStartingUnits> BonusMinorStartingUnits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Civics> Civics { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CommemorationTypes> CommemorationTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CommemorationTypes> CommemorationTypes1 { get; set; }

        public virtual Types Types { get; set; }

        public virtual Eras_XP1 Eras_XP1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GreatPersonIndividuals> GreatPersonIndividuals { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GreatWorks> GreatWorks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MajorStartingUnits> MajorStartingUnits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Moments> Moments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Moments> Moments1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Moments> Moments2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Policies_XP1> Policies_XP1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Policies_XP1> Policies_XP11 { get; set; }

        public virtual RandomAgendasInEra RandomAgendasInEra { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Routes> Routes { get; set; }

        public virtual StartEras StartEras { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StartingBuildings> StartingBuildings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StartingGovernments> StartingGovernments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Technologies> Technologies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RandomAgendaEraTags> RandomAgendaEraTags { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StartingBoostedCivics> StartingBoostedCivics { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StartingBoostedTechnologies> StartingBoostedTechnologies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StartingCivics> StartingCivics { get; set; }
    }
}
