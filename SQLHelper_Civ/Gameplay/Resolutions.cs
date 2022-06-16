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
    using SQLHelper_Civ.Globals;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Test.ORM.Localization;
    using static SQLHelper_Civ.Extensions_Helpers.Classes;

    public partial class Resolutions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Resolutions()
        {
            CongressAiChanges = new HashSet<CongressAiChanges>();
            ResolutionEffects = new HashSet<ResolutionEffects>();
        }

        [Key]
        [StringLength(2147483647)]
        public string ResolutionType { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string TargetKind { get; set; }

        [Required]
        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Name { get; set; }

        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Effect1Description { get; set; }

        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Effect2Description { get; set; }

        [StringLength(2147483647)]
        public string ValidationLua { get; set; }

        [StringLength(2147483647)]
        public string AITargetChooser { get; set; }

        [StringLength(2147483647)]
        public string AILuaTargetChooser { get; set; }

        public bool InjectionOnly { get; set; }

        [StringLength(2147483647)]
        public string EarliestEra { get; set; }

        [StringLength(2147483647)]
        public string LatestEra { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CongressAiChanges> CongressAiChanges { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ResolutionEffects> ResolutionEffects { get; set; }

        public virtual Types Types { get; set; }
    }
}
