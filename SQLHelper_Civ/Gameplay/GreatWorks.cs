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

    public partial class GreatWorks
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GreatWorks()
        {
            GreatWork_YieldChanges = new HashSet<GreatWork_YieldChanges>();
        }

        [Key]
        [StringLength(2147483647)]
        public string GreatWorkType { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string GreatWorkObjectType { get; set; }

        [StringLength(2147483647)]
        public string GreatPersonIndividualType { get; set; }

        [Required]
        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Name { get; set; }

        [StringLength(2147483647)]
        public string Audio { get; set; }

        [StringLength(2147483647)]
        public string Image { get; set; }

        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Quote { get; set; }

        public long Tourism { get; set; }

        [StringLength(2147483647)]
        public string EraType { get; set; }

        public virtual Eras Eras { get; set; }

        public virtual GreatPersonIndividuals GreatPersonIndividuals { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GreatWork_YieldChanges> GreatWork_YieldChanges { get; set; }

        public virtual GreatWorkObjectTypes GreatWorkObjectTypes { get; set; }
    }
}
