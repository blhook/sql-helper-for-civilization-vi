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

    public partial class ConfigurationUpdates
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
        public string SourceGroup { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(2147483647)]
        public string SourceId { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(2147483647)]
        public string SourceValue { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(2147483647)]
        public string TargetGroup { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(2147483647)]
        public string TargetId { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(2147483647)]
        public string TargetValue { get; set; }

        public bool Hash { get; set; }

        public bool Static { get; set; }
    }
}
