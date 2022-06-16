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

    public partial class Governors
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Governors()
        {
            GovernorModifiers = new HashSet<GovernorModifiers>();
            GovernorPromotionSets = new HashSet<GovernorPromotionSets>();
            GovernorReplaces1 = new HashSet<GovernorReplaces>();
            GovernorReplaces2 = new HashSet<GovernorReplaces>();
        }

        [Key]
        [StringLength(2147483647)]
        public string GovernorType { get; set; }

        [Required]
        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Name { get; set; }

        [Required]
        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Description { get; set; }

        public long IdentityPressure { get; set; }

        [Required]
        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Title { get; set; }

        [Required]
        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string ShortTitle { get; set; }

        public long TransitionStrength { get; set; }

        public bool AssignCityState { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Image { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string PortraitImage { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string PortraitImageSelected { get; set; }

        [StringLength(2147483647)]
        public string TraitType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GovernorModifiers> GovernorModifiers { get; set; }

        public virtual Traits Traits { get; set; }

        public virtual Types Types { get; set; }

        public virtual Governors_XP2 Governors_XP2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GovernorPromotionSets> GovernorPromotionSets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [InverseProperty(nameof(GovernorReplaces.UniqueGovernorTypeNavigation))]
        public virtual ICollection<GovernorReplaces> GovernorReplaces1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [InverseProperty(nameof(GovernorReplaces.ReplacesGovernorTypeNavigation))]
        public virtual ICollection<GovernorReplaces> GovernorReplaces2 { get; set; }
    }
}
