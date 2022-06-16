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

    public partial class BarbarianTribes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BarbarianTribes()
        {
            BarbarianTribeForces = new HashSet<BarbarianTribeForces>();
            BarbarianTribeNames = new HashSet<BarbarianTribeNames>();
        }

        [Key]
        [StringLength(2147483647)]
        public string TribeType { get; set; }

        public bool IsCoastal { get; set; }

        [StringLength(2147483647)]
        public string RequiredResource { get; set; }

        public long ResourceRange { get; set; }

        public long PercentRangedUnits { get; set; }

        public long TurnsToWarriorSpawn { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string ScoutTag { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string MeleeTag { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string RangedTag { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string SiegeTag { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string DefenderTag { get; set; }

        [StringLength(2147483647)]
        public string SupportTag { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string ScoutingBehaviorTree { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string RaidingBehaviorTree { get; set; }

        public long RaidingBoldness { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string CityAttackOperation { get; set; }

        public long CityAttackBoldness { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BarbarianTribeForces> BarbarianTribeForces { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BarbarianTribeNames> BarbarianTribeNames { get; set; }

        public virtual Resources Resources { get; set; }
    }
}