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

namespace Test.ORM.Localization
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class LanguagePriorities
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2147483647)]
        public string PrimaryLanguage { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2147483647)]
        public string Language { get; set; }

        public int Priority { get; set; }

        [ForeignKey(nameof(PrimaryLanguage))]
        public virtual Languages Language1 { get; set; }

        [ForeignKey(nameof(Language))]
        public virtual Languages Language2 { get; set; }
    }
}
