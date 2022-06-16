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

    public partial class UnitPromotions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UnitPromotions()
        {
            UnitPromotionModifiers = new HashSet<UnitPromotionModifiers>();
            UnitPromotionPrereqs1 = new HashSet<UnitPromotionPrereqs>();
            UnitPromotionPrereqs2 = new HashSet<UnitPromotionPrereqs>();
        }

        [Key]
        [StringLength(2147483647)]
        public string UnitPromotionType { get; set; }

        [Required]
        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Name { get; set; }

        [Required]
        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Description { get; set; }

        public long Level { get; set; }

        [StringLength(2147483647)]
        public string Specialization { get; set; }

        [StringLength(2147483647)]
        public string PromotionClass { get; set; }

        public long Column { get; set; }

        public virtual Types Types { get; set; }

        public virtual UnitPromotionClasses UnitPromotionClasses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UnitPromotionModifiers> UnitPromotionModifiers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [InverseProperty(nameof(UnitPromotionPrereqs.PrereqUnitPromotionNavigation))]
        public virtual ICollection<UnitPromotionPrereqs> UnitPromotionPrereqs1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [InverseProperty(nameof(UnitPromotionPrereqs.UnitPromotionNavigation))]
        public virtual ICollection<UnitPromotionPrereqs> UnitPromotionPrereqs2 { get; set; }
    }
}
