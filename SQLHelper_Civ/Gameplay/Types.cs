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

    public partial class Types
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Types()
        {
            DynamicModifiers = new HashSet<DynamicModifiers>();
            DynamicModifiers2 = new HashSet<DynamicModifiers>();
            MomentIllustrations = new HashSet<MomentIllustrations>();
            TypeProperties = new HashSet<TypeProperties>();
            TypeTags = new HashSet<TypeTags>();
        }

        [Key]
        [StringLength(2147483647)]
        public string Type { get; set; }

        public long Hash { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Kind { get; set; }

        public virtual Alliances Alliances { get; set; }

        public virtual Beliefs Beliefs { get; set; }

        public virtual Buildings Buildings { get; set; }

        public virtual Civics Civics { get; set; }

        public virtual Civilizations Civilizations { get; set; }

        public virtual Defeats Defeats { get; set; }

        public virtual DiplomaticActions DiplomaticActions { get; set; }

        public virtual Discussions Discussions { get; set; }

        public virtual Districts Districts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DynamicModifiers> DynamicModifiers { get; set; }

        public virtual DynamicModifiers DynamicModifiers1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DynamicModifiers> DynamicModifiers2 { get; set; }

        public virtual EmergencyAlliances EmergencyAlliances { get; set; }

        public virtual Eras Eras { get; set; }

        public virtual Features Features { get; set; }

        public virtual GameCapabilities GameCapabilities { get; set; }

        public virtual GameEffects GameEffects { get; set; }

        public virtual Gossips Gossips { get; set; }

        public virtual Governments Governments { get; set; }

        public virtual Governors Governors { get; set; }

        public virtual GreatPersonClasses GreatPersonClasses { get; set; }

        public virtual GreatPersonIndividuals GreatPersonIndividuals { get; set; }

        public virtual Improvements Improvements { get; set; }

        public virtual Kinds Kinds { get; set; }

        public virtual Leaders Leaders { get; set; }

        public virtual LoadingInfo LoadingInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MomentIllustrations> MomentIllustrations { get; set; }

        public virtual Moments Moments { get; set; }

        public virtual Policies Policies { get; set; }

        public virtual Projects Projects { get; set; }

        public virtual ProposalBlockers ProposalBlockers { get; set; }

        public virtual ProposalTypes ProposalTypes { get; set; }

        public virtual Quests Quests { get; set; }

        public virtual Religions Religions { get; set; }

        public virtual Resolutions Resolutions { get; set; }

        public virtual Resources Resources { get; set; }

        public virtual Routes Routes { get; set; }

        public virtual Technologies Technologies { get; set; }

        public virtual Traits Traits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TypeProperties> TypeProperties { get; set; }

        public virtual UnitPromotionClasses UnitPromotionClasses { get; set; }

        public virtual UnitPromotions UnitPromotions { get; set; }

        public virtual Units Units { get; set; }

        public virtual Victories Victories { get; set; }

        public virtual VotingBlockers VotingBlockers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TypeTags> TypeTags { get; set; }
    }
}
