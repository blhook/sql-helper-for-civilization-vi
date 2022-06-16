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
    public partial class CivicModifiers
    {
        [Key]
        [Column(Order = 0)]
        public string CivicType { get; set; }
        [Key]
        [Column(Order = 1)]
        public string ModifierId { get; set; }

        [ForeignKey("CivicType")]
        public virtual Civics CivicTypeNavigation { get; set; }
        [ForeignKey("ModifierId")]
        public virtual Modifiers Modifier { get; set; }
    }
}