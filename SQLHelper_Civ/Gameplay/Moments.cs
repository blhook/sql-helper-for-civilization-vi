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
    using System.ComponentModel.DataAnnotations;
    using Test.ORM.Localization;
    using static SQLHelper_Civ.Extensions_Helpers.Classes;

    public partial class Moments
    {
        [Key]
        [StringLength(2147483647)]
        public string MomentType { get; set; }

        [Required]
        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Name { get; set; }

        [Required]
        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Description { get; set; }

        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string InstanceDescription { get; set; }

        public long InterestLevel { get; set; }

        public long? EraScore { get; set; }

        public long? RepeatTurnCooldown { get; set; }

        [StringLength(2147483647)]
        public string CommemorationType { get; set; }

        [StringLength(2147483647)]
        public string MinimumGameEra { get; set; }

        [StringLength(2147483647)]
        public string MaximumGameEra { get; set; }

        [StringLength(2147483647)]
        public string BackgroundTexture { get; set; }

        [StringLength(2147483647)]
        public string IconTexture { get; set; }

        [StringLength(2147483647)]
        public string MomentIllustrationType { get; set; }

        [StringLength(2147483647)]
        public string ObsoleteEra { get; set; }

        public virtual CommemorationTypes CommemorationTypes { get; set; }

        public virtual Eras Eras { get; set; }

        public virtual Eras Eras1 { get; set; }

        public virtual Eras Eras2 { get; set; }

        public virtual MomentIllustrationTypes MomentIllustrationTypes { get; set; }

        public virtual Types Types { get; set; }
    }
}
