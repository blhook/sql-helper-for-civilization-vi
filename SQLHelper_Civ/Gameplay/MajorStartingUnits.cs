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
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class MajorStartingUnits
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2147483647)]
        public string Unit { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2147483647)]
        public string Era { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2147483647)]
        public string District { get; set; }

        public long Quantity { get; set; }

        public bool NotStartTile { get; set; }

        public bool OnDistrictCreated { get; set; }

        public bool AiOnly { get; set; }

        [StringLength(2147483647)]
        public string MinDifficulty { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "real")]
        public double DifficultyDelta { get; set; }

        public virtual Difficulties_Gameplay Difficulties { get; set; }

        public virtual Districts Districts { get; set; }

        public virtual Eras Eras { get; set; }

        public virtual Units Units { get; set; }
    }
}
