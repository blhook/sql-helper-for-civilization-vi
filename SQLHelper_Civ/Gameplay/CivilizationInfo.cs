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
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Test.ORM.Localization;
    using static SQLHelper_Civ.Extensions_Helpers.Classes;

    [Table("CivilizationInfo")]
    public partial class CivilizationInfo
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2147483647)]
        public string CivilizationType { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Header { get; set; }

        [Required]
        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Caption { get; set; }

        public long SortIndex { get; set; }

        public virtual Civilizations Civilizations { get; set; }
    }
}
