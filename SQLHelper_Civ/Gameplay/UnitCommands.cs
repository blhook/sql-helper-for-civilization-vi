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
    using Test.ORM.Localization;
    using static SQLHelper_Civ.Extensions_Helpers.Classes;

    public partial class UnitCommands
    {
        [Key]
        [StringLength(2147483647)]
        public string CommandType { get; set; }

        [Required]
        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Description { get; set; }

        [StringLength(2147483647)]
        public string Help { get; set; }

        [StringLength(2147483647)]
        public string DisabledHelp { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Icon { get; set; }

        [StringLength(2147483647)]
        public string Sound { get; set; }

        public bool VisibleInUI { get; set; }

        public bool HoldCycling { get; set; }

        [StringLength(2147483647)]
        public string CategoryInUI { get; set; }

        [StringLength(2147483647)]
        public string InterfaceMode { get; set; }

        [StringLength(2147483647)]
        public string PrereqTech { get; set; }

        [StringLength(2147483647)]
        public string PrereqCivic { get; set; }

        public long MaxEra { get; set; }

        [StringLength(2147483647)]
        public string HotkeyId { get; set; }

        public virtual Civics Civics { get; set; }

        public virtual Technologies Technologies { get; set; }
    }
}
