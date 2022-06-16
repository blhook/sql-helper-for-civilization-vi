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

    public partial class GreatPersonIndividuals
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GreatPersonIndividuals()
        {
            DiplomaticVisibilitySources = new HashSet<DiplomaticVisibilitySources>();
            GreatPersonIndividualActionModifiers = new HashSet<GreatPersonIndividualActionModifiers>();
            GreatPersonIndividualBirthModifiers = new HashSet<GreatPersonIndividualBirthModifiers>();
            GreatWorks = new HashSet<GreatWorks>();
        }

        [Key]
        [StringLength(2147483647)]
        public string GreatPersonIndividualType { get; set; }

        [Required]
        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Name { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string GreatPersonClassType { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string EraType { get; set; }

        public long ActionCharges { get; set; }

        public bool ActionRequiresOwnedTile { get; set; }

        public bool ActionRequiresUnownedTile { get; set; }

        public bool ActionRequiresAdjacentMountain { get; set; }

        public bool ActionRequiresAdjacentOwnedTile { get; set; }

        public bool ActionRequiresAdjacentBarbarianUnit { get; set; }

        public bool ActionRequiresOnOrAdjacentNaturalWonder { get; set; }

        [StringLength(2147483647)]
        public string ActionRequiresOnOrAdjacentFeatureType { get; set; }

        public bool ActionRequiresIncompleteWonder { get; set; }

        public bool ActionRequiresIncompleteSpaceRaceProject { get; set; }

        public bool ActionRequiresVisibleLuxury { get; set; }

        public bool ActionRequiresNoMilitaryUnit { get; set; }

        public bool ActionRequiresPlayerRelicSlot { get; set; }

        [StringLength(2147483647)]
        public string ActionRequiresMilitaryUnitDomain { get; set; }

        [StringLength(2147483647)]
        public string ActionRequiresUnitMilitaryFormation { get; set; }

        [StringLength(2147483647)]
        public string ActionRequiresCityGreatWorkObjectType { get; set; }

        [StringLength(2147483647)]
        public string ActionRequiresCompletedDistrictType { get; set; }

        [StringLength(2147483647)]
        public string ActionRequiresMissingBuildingType { get; set; }

        public long? ActionRequiresGoldCost { get; set; }

        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string ActionNameTextOverride { get; set; }

        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string ActionEffectTextOverride { get; set; }

        public bool ActionEffectTileHighlighting { get; set; }

        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string BirthNameTextOverride { get; set; }

        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string BirthEffectTextOverride { get; set; }

        public long? AreaHighlightRadius { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Gender { get; set; }

        public virtual Buildings Buildings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiplomaticVisibilitySources> DiplomaticVisibilitySources { get; set; }

        public virtual Districts Districts { get; set; }

        public virtual Eras Eras { get; set; }

        public virtual Features Features { get; set; }

        public virtual GreatPersonClasses GreatPersonClasses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GreatPersonIndividualActionModifiers> GreatPersonIndividualActionModifiers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GreatPersonIndividualBirthModifiers> GreatPersonIndividualBirthModifiers { get; set; }

        public virtual Types Types { get; set; }

        public virtual GreatWorkObjectTypes GreatWorkObjectTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GreatWorks> GreatWorks { get; set; }
    }
}
