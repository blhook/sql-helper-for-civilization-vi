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

    public partial class Requirements
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Requirements()
        {
            RequirementArguments = new HashSet<RequirementArguments>();
            RequirementStrings = new HashSet<RequirementStrings>();
            RequirementSetRequirements = new HashSet<RequirementSetRequirements>();
        }

        [Key]
        [StringLength(2147483647)]
        public string RequirementId { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string RequirementType { get; set; }

        public long Likeliness { get; set; }

        public long Impact { get; set; }

        public bool Inverse { get; set; }

        public bool Reverse { get; set; }

        public bool Persistent { get; set; }

        public long ProgressWeight { get; set; }

        public bool Triggered { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequirementArguments> RequirementArguments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequirementStrings> RequirementStrings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequirementSetRequirements> RequirementSetRequirements { get; set; }
    }
}
