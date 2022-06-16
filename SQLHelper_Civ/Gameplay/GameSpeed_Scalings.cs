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

    public partial class GameSpeed_Scalings
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GameSpeed_Scalings()
        {
            GameSpeed_Durations = new HashSet<GameSpeed_Durations>();
        }

        [Key]
        [StringLength(2147483647)]
        public string GameSpeedScalingType { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string GameSpeedType { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string ScalingType { get; set; }

        public long DefaultCostMultiplier { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GameSpeed_Durations> GameSpeed_Durations { get; set; }

        public virtual GameSpeeds GameSpeeds { get; set; }
    }
}
