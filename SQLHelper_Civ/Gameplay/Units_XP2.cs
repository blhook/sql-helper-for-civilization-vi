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

    public partial class Units_XP2
    {
        [Key]
        [StringLength(2147483647)]
        public string UnitType { get; set; }

        public long ResourceMaintenanceAmount { get; set; }

        public long ResourceCost { get; set; }

        [StringLength(2147483647)]
        public string ResourceMaintenanceType { get; set; }

        public long TourismBomb { get; set; }

        public bool CanEarnExperience { get; set; }

        public bool TourismBombPossible { get; set; }

        public bool CanFormMilitaryFormation { get; set; }

        public bool MajorCivOnly { get; set; }

        public virtual Resources Resources { get; set; }

        public virtual Units Units { get; set; }
    }
}
