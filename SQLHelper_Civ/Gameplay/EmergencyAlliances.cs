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
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Test.ORM.Localization;
    using static SQLHelper_Civ.Extensions_Helpers.Classes;

    public partial class EmergencyAlliances
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmergencyAlliances()
        {
            EmergencyBuffs = new HashSet<EmergencyBuffs>();
            EmergencyRewards = new HashSet<EmergencyRewards>();
        }

        [Key]
        [StringLength(2147483647)]
        public string EmergencyType { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Trigger { get; set; }

        [StringLength(2147483647)]
        public string TargetRequirementSet { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string GoalTrigger { get; set; }

        [StringLength(2147483647)]
        public string MemberRequirementSet { get; set; }

        public long Duration { get; set; }

        public bool RemovesWarState { get; set; }

        public bool ShareVis { get; set; }

        public bool OpenBorders { get; set; }

        public bool KillFriendship { get; set; }

        public bool WarOnTarget { get; set; }

        public bool InformTarget { get; set; }

        public long LockoutTime { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string EmergencyText { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string GoalText { get; set; }

        [Required]
        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Name { get; set; }

        public virtual Emergencies_XP2 Emergencies_XP2 { get; set; }

        public virtual EmergencyGoalTexts EmergencyGoalTexts { get; set; }

        public virtual EmergencyTexts EmergencyTexts { get; set; }

        public virtual Types Types { get; set; }

        public virtual RequirementSets RequirementSets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmergencyBuffs> EmergencyBuffs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmergencyRewards> EmergencyRewards { get; set; }
    }
}
