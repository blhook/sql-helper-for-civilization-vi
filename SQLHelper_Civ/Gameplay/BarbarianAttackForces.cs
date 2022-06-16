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
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class BarbarianAttackForces
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BarbarianAttackForces()
        {
            BarbarianTribeForces = new HashSet<BarbarianTribeForces>();
        }

        [Key]
        [StringLength(2147483647)]
        public string AttackForceType { get; set; }

        [StringLength(2147483647)]
        public string MinTargetDifficulty { get; set; }

        [StringLength(2147483647)]
        public string MaxTargetDifficulty { get; set; }

        public long SpawnRate { get; set; }

        [StringLength(2147483647)]
        public string MeleeTag { get; set; }

        public long NumMeleeUnits { get; set; }

        [StringLength(2147483647)]
        public string RangeTag { get; set; }

        public long NumRangeUnits { get; set; }

        [StringLength(2147483647)]
        public string SiegeTag { get; set; }

        public long NumSiegeUnits { get; set; }

        [StringLength(2147483647)]
        public string SupportTag { get; set; }

        public long NumSupportUnits { get; set; }

        public bool RaidingForce { get; set; }

        public virtual Difficulties_Gameplay Difficulties { get; set; }

        public virtual Difficulties_Gameplay Difficulties1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BarbarianTribeForces> BarbarianTribeForces { get; set; }
    }
}
