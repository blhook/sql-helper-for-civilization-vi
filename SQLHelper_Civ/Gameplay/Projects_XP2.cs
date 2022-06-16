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

    public partial class Projects_XP2
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Projects_XP2()
        {
            EmergencyScoreSources = new HashSet<EmergencyScoreSources>();
            Project_BuildingCosts = new HashSet<Project_BuildingCosts>();
        }

        [Key]
        [StringLength(2147483647)]
        public string ProjectType { get; set; }

        public long RequiredPowerWhileActive { get; set; }

        public long ReligiousPressureModifier { get; set; }

        public bool UnlocksFromEffect { get; set; }

        [StringLength(2147483647)]
        public string RequiredBuilding { get; set; }

        [StringLength(2147483647)]
        public string CreateBuilding { get; set; }

        public bool? FullyPoweredWhileActive { get; set; }

        public long? MaxSimultaneousInstances { get; set; }

        public virtual Buildings Buildings { get; set; }

        public virtual Buildings Buildings1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmergencyScoreSources> EmergencyScoreSources { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Project_BuildingCosts> Project_BuildingCosts { get; set; }

        public virtual Projects Projects { get; set; }
    }
}
