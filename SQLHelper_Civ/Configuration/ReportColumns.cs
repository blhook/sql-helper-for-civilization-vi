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

    public partial class ReportColumns
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2147483647)]
        public string Report { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2147483647)]
        public string Name { get; set; }

        [StringLength(2147483647)]
        public string Description { get; set; }

        public long SortOrder { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string DataPoint { get; set; }

        [StringLength(2147483647)]
        public string UxHint { get; set; }

        public bool Minor { get; set; }

        public bool AlwaysShow { get; set; }

        [StringLength(2147483647)]
        public string EmptyValue { get; set; }

        [StringLength(2147483647)]
        public string DefaultValue { get; set; }

        [StringLength(2147483647)]
        public string ValueIconDefault { get; set; }

        [StringLength(2147483647)]
        public string ValueIconOverride { get; set; }

        public virtual Reports Reports { get; set; }
    }
}
