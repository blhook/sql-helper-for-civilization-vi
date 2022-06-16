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

    public partial class CivilizationLevels
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CivilizationLevels()
        {
            Civilizations = new HashSet<Civilizations>();
            DiplomaticStartStates = new HashSet<DiplomaticStartStates>();
            DiplomaticStartStates1 = new HashSet<DiplomaticStartStates>();
            DiplomaticTriggeredTransitions = new HashSet<DiplomaticTriggeredTransitions>();
            DiplomaticTriggeredTransitions1 = new HashSet<DiplomaticTriggeredTransitions>();
        }

        [Key]
        [StringLength(2147483647)]
        public string CivilizationLevelType { get; set; }

        public bool CanFoundCities { get; set; }

        public bool CanAnnexTilesWithCulture { get; set; }

        public bool CanAnnexTilesWithGold { get; set; }

        public bool CanAnnexTilesWithReceivedInfluence { get; set; }

        public bool CanEarnGreatPeople { get; set; }

        public bool CanGiveInfluence { get; set; }

        public bool CanReceiveInfluence { get; set; }

        public long StartingTilesForCity { get; set; }

        public bool CanBuildWonders { get; set; }

        public bool IgnoresUnitStrategicResourceRequirements { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Civilizations> Civilizations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiplomaticStartStates> DiplomaticStartStates { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiplomaticStartStates> DiplomaticStartStates1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiplomaticTriggeredTransitions> DiplomaticTriggeredTransitions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiplomaticTriggeredTransitions> DiplomaticTriggeredTransitions1 { get; set; }
    }
}
