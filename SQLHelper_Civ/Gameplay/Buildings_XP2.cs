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

    public partial class Buildings_XP2
    {
        [Key]
        [StringLength(2147483647)]
        public string BuildingType { get; set; }

        public long RequiredPower { get; set; }

        [StringLength(2147483647)]
        public string ResourceTypeConvertedToPower { get; set; }

        public bool PreventsFloods { get; set; }

        public bool PreventsDrought { get; set; }

        public bool BlocksCoastalFlooding { get; set; }

        public long CostMultiplierPerTile { get; set; }

        public long CostMultiplierPerSeaLevel { get; set; }

        public bool Bridge { get; set; }

        public bool CanalWonder { get; set; }

        public long EntertainmentBonusWithPower { get; set; }

        public bool NuclearReactor { get; set; }

        public bool Pillage { get; set; }

        public virtual Buildings Buildings { get; set; }

        public virtual Resources Resources { get; set; }
    }
}
