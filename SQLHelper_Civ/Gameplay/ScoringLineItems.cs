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
    using System.ComponentModel.DataAnnotations.Schema;
    using Test.ORM.Localization;
    using static SQLHelper_Civ.Extensions_Helpers.Classes;

    public partial class ScoringLineItems
    {
        [Key]
        [StringLength(2147483647)]
        public string LineItemType { get; set; }

        [Required]
        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Name { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Category { get; set; }

        [Column(TypeName = "real")]
        public double Multiplier { get; set; }

        public bool ScaleByCost { get; set; }

        public bool Civics { get; set; }

        public bool Cities { get; set; }

        public bool Districts { get; set; }

        public bool Population { get; set; }

        public bool GreatPeople { get; set; }

        public bool Techs { get; set; }

        public bool Wonders { get; set; }

        public bool Religion { get; set; }

        public bool Pillage { get; set; }

        public bool Trade { get; set; }

        public bool GoldPerTurn { get; set; }

        public long TieBreakerPriority { get; set; }

        public bool ScoringScenario1 { get; set; }

        public bool ScoringScenario2 { get; set; }

        public bool ScoringScenario3 { get; set; }

        public bool EraScore { get; set; }

        public bool Converted { get; set; }

        public bool Buildings { get; set; }

        public virtual ScoringCategories ScoringCategories { get; set; }
    }
}
