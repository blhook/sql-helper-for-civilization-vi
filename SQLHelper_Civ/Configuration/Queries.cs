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

    public partial class Queries
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Queries()
        {
            //ConfigurationUpdateQueries = new HashSet<ConfigurationUpdateQueries>();
            DomainOverrideQueries = new HashSet<DomainOverrideQueries>();
            DomainRangeQueries = new HashSet<DomainRangeQueries>();
            DomainValueFilterQueries = new HashSet<DomainValueFilterQueries>();
            DomainValueQueries = new HashSet<DomainValueQueries>();
            DomainValueUnionQueries = new HashSet<DomainValueUnionQueries>();
            ParameterQueries = new HashSet<ParameterQueries>();
            QueryCriteria = new HashSet<QueryCriteria>();
            QueryParameters = new HashSet<QueryParameters>();
        }

        [Key]
        [StringLength(2147483647)]
        public string QueryId { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string SQL { get; set; }

        /// <summary>
        /// Come back to this. -Z
        /// </summary>
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ConfigurationUpdateQueries> ConfigurationUpdateQueries { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DomainOverrideQueries> DomainOverrideQueries { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DomainRangeQueries> DomainRangeQueries { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DomainValueFilterQueries> DomainValueFilterQueries { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DomainValueQueries> DomainValueQueries { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DomainValueUnionQueries> DomainValueUnionQueries { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ParameterQueries> ParameterQueries { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QueryCriteria> QueryCriteria { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QueryParameters> QueryParameters { get; set; }
    }
}
