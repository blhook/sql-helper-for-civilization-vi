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

    public partial class Modifiers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Modifiers()
        {
            AllianceEffects = new HashSet<AllianceEffects>();
            EmergencyBuffs = new HashSet<EmergencyBuffs>();
            EmergencyRewards = new HashSet<EmergencyRewards>();
            ModifierArguments = new HashSet<ModifierArguments>();
            ModifierStrings = new HashSet<ModifierStrings>();
            CivicModifiers = new HashSet<CivicModifiers>();
            DistrictModifiers = new HashSet<DistrictModifiers>();
            TraitModifiers = new HashSet<TraitModifiers>();
            UnitAbilityModifiers = new HashSet<UnitAbilityModifiers>();
        }

        [Key]
        [StringLength(2147483647)]
        public string ModifierId { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string ModifierType { get; set; }

        public bool RunOnce { get; set; }

        public bool NewOnly { get; set; }

        public bool Permanent { get; set; }

        [StringLength(2147483647)]
        public string OwnerRequirementSetId { get; set; }

        [StringLength(2147483647)]
        public string SubjectRequirementSetId { get; set; }

        public long? OwnerStackLimit { get; set; }

        public long? SubjectStackLimit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AllianceEffects> AllianceEffects { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmergencyBuffs> EmergencyBuffs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmergencyRewards> EmergencyRewards { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ModifierArguments> ModifierArguments { get; set; }

        public virtual RequirementSets RequirementSets { get; set; }

        public virtual RequirementSets RequirementSets1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ModifierStrings> ModifierStrings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CivicModifiers> CivicModifiers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DistrictModifiers> DistrictModifiers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TraitModifiers> TraitModifiers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UnitAbilityModifiers> UnitAbilityModifiers { get; set; }
    }
}
