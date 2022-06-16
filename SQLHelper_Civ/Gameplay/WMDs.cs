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

    public partial class WMDs
    {
        [Key]
        [StringLength(2147483647)]
        public string WeaponType { get; set; }

        [Required]
        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Name { get; set; }

        public long BlastRadius { get; set; }

        public long FalloutDuration { get; set; }

        public bool AffectPopulation { get; set; }

        public bool AffectImprovements { get; set; }

        public bool AffectBuildings { get; set; }

        public bool AffectUnits { get; set; }

        public bool AffectResources { get; set; }

        public bool AffectRoutes { get; set; }

        public long ICBMStrikeRange { get; set; }

        public long Maintenance { get; set; }
    }
}
