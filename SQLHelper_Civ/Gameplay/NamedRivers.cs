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

    public partial class NamedRivers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NamedRivers()
        {
            NamedRiverCivilizations = new HashSet<NamedRiverCivilizations>();
        }

        [Key]
        [StringLength(2147483647)]
        public string NamedRiverType { get; set; }

        [Required]
        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NamedRiverCivilizations> NamedRiverCivilizations { get; set; }
    }
}
