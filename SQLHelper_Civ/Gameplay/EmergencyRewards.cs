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

    public partial class EmergencyRewards
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2147483647)]
        public string ModifierID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2147483647)]
        public string EmergencyType { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool OnSuccess { get; set; }

        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Description { get; set; }

        public bool FirstPlace { get; set; }

        public bool TopTier { get; set; }

        public bool BottomTier { get; set; }

        public virtual EmergencyAlliances EmergencyAlliances { get; set; }

        public virtual Modifiers Modifiers { get; set; }
    }
}
