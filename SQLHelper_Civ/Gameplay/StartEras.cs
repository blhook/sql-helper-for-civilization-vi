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
    using System.ComponentModel.DataAnnotations;

    public partial class StartEras
    {
        [Key]
        [StringLength(2147483647)]
        public string EraType { get; set; }

        public long Gold { get; set; }

        public long Faith { get; set; }

        public bool FirstTurnCivicChange { get; set; }

        public long StartingPopulationCapital { get; set; }

        public long StartingPopulationOtherCities { get; set; }

        public long GrowthRate { get; set; }

        public long ProductionRate { get; set; }

        public long DistrictProductionRate { get; set; }

        public long StartingMeleeStrengthMajor { get; set; }

        public long StartingMeleeStrengthMinor { get; set; }

        public bool ObsoleteReligion { get; set; }

        public long Tiles { get; set; }

        public long Year { get; set; }

        public bool IgnoreGoodyHutTurn { get; set; }

        public long StartingRangedStrengthMajor { get; set; }

        public long StartingRangedStrengthMinor { get; set; }

        public long StartingAmenitiesCapital { get; set; }

        public long StartingHousingCapital { get; set; }

        public long StartingAmenitiesOtherCities { get; set; }

        public long StartingHousingOtherCities { get; set; }

        public virtual Eras Eras { get; set; }

        public virtual StartEras_XP2 StartEras_XP2 { get; set; }
    }
}
