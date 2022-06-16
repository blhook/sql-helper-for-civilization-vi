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

namespace Test.ORM.Configuration
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Rulesets
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rulesets()
        {
            RulesetTypes = new HashSet<RulesetTypes>();
        }

        [Key]
        [StringLength(2147483647)]
        public string RulesetType { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Name { get; set; }

        [StringLength(2147483647)]
        public string Description { get; set; }

        [StringLength(2147483647)]
        public string LongDescription { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string DefeatDomain { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string VictoryDomain { get; set; }

        public long? MaxTurns { get; set; }

        public bool FixedMaxTurns { get; set; }

        public bool SupportsSinglePlayer { get; set; }

        public bool SupportsMultiPlayer { get; set; }

        public bool SupportsHotSeat { get; set; }

        public bool SupportsPlayByCloud { get; set; }

        public long SortIndex { get; set; }

        public bool IsScenario { get; set; }

        public bool RequiresNoTeams { get; set; }

        public bool RequiresUniqueCivilizations { get; set; }

        public bool RequiresUniqueLeaders { get; set; }

        [StringLength(2147483647)]
        public string ScenarioSetupPortrait { get; set; }

        [StringLength(2147483647)]
        public string ScenarioSetupPortraitBackground { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string GameCore { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RulesetTypes> RulesetTypes { get; set; }
    }
}
