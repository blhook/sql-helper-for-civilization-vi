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
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Parameters
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2147483647)]
        public string Key1 { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2147483647)]
        public string Key2 { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2147483647)]
        public string ParameterId { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Name { get; set; }

        [StringLength(2147483647)]
        public string Description { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Domain { get; set; }

        public bool Hash { get; set; }

        /// <summary>
        /// SQLite's non-rigid style has left the devs to abuse this, so this field is more or less dead. 
        /// </summary>
        //[StringLength(2147483647)]
        //public string DefaultValue { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string ConfigurationGroup { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string ConfigurationId { get; set; }

        [StringLength(2147483647)]
        public string DomainConfigurationId { get; set; }

        [StringLength(2147483647)]
        public string DomainValuesConfigurationId { get; set; }

        [StringLength(2147483647)]
        public string ValueNameConfigurationId { get; set; }

        [StringLength(2147483647)]
        public string ValueDomainConfigurationId { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string GroupId { get; set; }

        public bool Visible { get; set; }

        public bool ReadOnly { get; set; }

        public bool SupportsSinglePlayer { get; set; }

        public bool SupportsLANMultiplayer { get; set; }

        public bool SupportsInternetMultiplayer { get; set; }

        public bool SupportsHotSeat { get; set; }

        public bool SupportsPlayByCloud { get; set; }

        public bool ChangeableAfterGameStart { get; set; }

        public bool ChangeableAfterPlayByCloudMatchCreate { get; set; }

        public long SortIndex { get; set; }
    }
}
