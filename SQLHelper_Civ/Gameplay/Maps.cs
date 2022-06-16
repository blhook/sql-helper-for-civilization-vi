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

    public partial class Maps
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Maps()
        {
            Map_GreatPersonClasses = new HashSet<Map_GreatPersonClasses>();
        }

        [Key]
        [StringLength(2147483647)]
        public string MapSizeType { get; set; }

        [Required]
        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Name { get; set; }

        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Description { get; set; }

        public long DefaultPlayers { get; set; }

        public long FogTilesPerBarbarianCamp { get; set; }

        public long NumNaturalWonders { get; set; }

        public long UnitNameModifier { get; set; }

        public long TargetNumCities { get; set; }

        public long GridWidth { get; set; }

        public long GridHeight { get; set; }

        public long TerrainGrainChange { get; set; }

        public long FeatureGrainChange { get; set; }

        public long ResearchPercent { get; set; }

        public long NumCitiesUnhealthPercent { get; set; }

        public long NumCitiesPolicyCostMod { get; set; }

        public long NumCitiesTechCostMod { get; set; }

        public long EstimatedNumCities { get; set; }

        public long PlateValue { get; set; }

        public long Continents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Map_GreatPersonClasses> Map_GreatPersonClasses { get; set; }

        public virtual Maps_XP2 Maps_XP2 { get; set; }
    }
}
