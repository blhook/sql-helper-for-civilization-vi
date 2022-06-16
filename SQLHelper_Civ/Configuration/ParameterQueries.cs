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
    using System.ComponentModel.DataAnnotations;

    public partial class ParameterQueries
    {
        [Key]
        [StringLength(2147483647)]
        public string ParameterQueryId { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string QueryId { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string ParameterIdField { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string NameField { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string DescriptionField { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string DomainField { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string HashField { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string DefaultValueField { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string ConfigurationGroupField { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string ConfigurationIdField { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string DomainConfigurationIdField { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string DomainValuesConfigurationIdField { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string ValueNameConfigurationIdField { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string ValueDomainConfigurationIdField { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string GroupField { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string VisibleField { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string ReadOnlyField { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string SupportsSinglePlayerField { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string SupportsLANMultiplayerField { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string SupportsInternetMultiplayerField { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string SupportsHotSeatField { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string SupportsPlayByCloudField { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string ChangeableAfterGameStartField { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string ChangeableAfterPlayByCloudMatchCreateField { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string SortIndexField { get; set; }

        public virtual Queries Queries { get; set; }
    }
}
