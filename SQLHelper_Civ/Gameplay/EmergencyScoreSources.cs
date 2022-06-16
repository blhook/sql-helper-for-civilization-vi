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

    public partial class EmergencyScoreSources
    {
        [Key]
        [StringLength(2147483647)]
        public string ScoreSourceType { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string EmergencyType { get; set; }

        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Description { get; set; }

        public long ScoreAmount { get; set; }

        [StringLength(2147483647)]
        public string FromProject { get; set; }

        public bool MilitaryInEnemyTerritory { get; set; }

        public bool ReligiousInEnemyTerritory { get; set; }

        public bool AttackedEnemyCity { get; set; }

        public bool FromGold { get; set; }

        public bool KilledEnemyUnit { get; set; }

        public bool SpreadReligion { get; set; }

        public bool ReligionAttackedEnemy { get; set; }

        public bool ReligiousUnitsInEnemyTerritory { get; set; }

        [StringLength(2147483647)]
        public string FromGreatPerson { get; set; }

        public bool FromFavor { get; set; }

        [StringLength(2147483647)]
        public string FromBuilding { get; set; }

        [StringLength(2147483647)]
        public string FromDistrict { get; set; }

        public bool FromCO2Footprint { get; set; }

        public virtual Buildings Buildings { get; set; }

        public virtual Districts Districts { get; set; }

        public virtual Emergencies_XP2 Emergencies_XP2 { get; set; }

        public virtual Projects_XP2 Projects_XP2 { get; set; }

        public virtual GreatPersonClasses GreatPersonClasses { get; set; }

        public virtual Projects Projects { get; set; }
    }
}
