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

    public partial class Governments
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Governments()
        {
            Government_SlotCounts = new HashSet<Government_SlotCounts>();
            GovernmentModifiers = new HashSet<GovernmentModifiers>();
            StartingGovernments = new HashSet<StartingGovernments>();
            Policy_GovernmentExclusives_XP2 = new HashSet<Policy_GovernmentExclusives_XP2>();
        }

        [Key]
        [StringLength(2147483647)]
        public string GovernmentType { get; set; }

        [Required]
        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Name { get; set; }

        [StringLength(2147483647)]
        public string PrereqCivic { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string InherentBonusDesc { get; set; }

        [Required]
        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string AccumulatedBonusShortDesc { get; set; }

        [Required]
        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string AccumulatedBonusDesc { get; set; }

        public long OtherGovernmentIntolerance { get; set; }

        public long InfluencePointsPerTurn { get; set; }

        public long InfluencePointsThreshold { get; set; }

        public long InfluenceTokensPerThreshold { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string BonusType { get; set; }

        [StringLength(2147483647)]
        public string PolicyToUnlock { get; set; }

        [StringLength(2147483647)]
        public string Tier { get; set; }

        public virtual Civics Civics { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Government_SlotCounts> Government_SlotCounts { get; set; }

        public virtual GovernmentBonusNames GovernmentBonusNames { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GovernmentModifiers> GovernmentModifiers { get; set; }

        public virtual GovernmentTiers GovernmentTiers { get; set; }

        public virtual Policies Policies { get; set; }

        public virtual Types Types { get; set; }

        public virtual Governments_XP2 Governments_XP2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StartingGovernments> StartingGovernments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Policy_GovernmentExclusives_XP2> Policy_GovernmentExclusives_XP2 { get; set; }
    }
}
