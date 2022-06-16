﻿// Copyright (C) 2022 Brandon Hook
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

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test.ORM.Gameplay
{
    public partial class Policy_GovernmentExclusives_XP2
    {
        [Key]
        [Column(Order = 0)]
        public string PolicyType { get; set; }
        [Key]
        [Column(Order = 1)]
        public string GovernmentType { get; set; }

        [ForeignKey("GovernmentType")]
        public virtual Governments GovernmentTypeNavigation { get; set; }
        [ForeignKey("PolicyType")]
        public virtual Policies PolicyTypeNavigation { get; set; }
    }
}
