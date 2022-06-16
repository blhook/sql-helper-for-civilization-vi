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

    public partial class Boosts
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long BoostID { get; set; }

        [StringLength(2147483647)]
        public string TechnologyType { get; set; }

        [StringLength(2147483647)]
        public string CivicType { get; set; }

        public long Boost { get; set; }

        public long TriggerId { get; set; }

        [Required]
        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string TriggerDescription { get; set; }

        [Required]
        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string TriggerLongDescription { get; set; }

        [StringLength(2147483647)]
        public string Unit1Type { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string BoostClass { get; set; }

        [StringLength(2147483647)]
        public string Unit2Type { get; set; }

        [StringLength(2147483647)]
        public string BuildingType { get; set; }

        [StringLength(2147483647)]
        public string ImprovementType { get; set; }

        [StringLength(2147483647)]
        public string BoostingTechType { get; set; }

        [StringLength(2147483647)]
        public string ResourceType { get; set; }

        public long NumItems { get; set; }

        [StringLength(2147483647)]
        public string DistrictType { get; set; }

        public bool RequiresResource { get; set; }

        [StringLength(2147483647)]
        public string RequirementSetId { get; set; }

        [StringLength(2147483647)]
        public string GovernmentSlotType { get; set; }

        [StringLength(2147483647)]
        public string BoostingCivicType { get; set; }

        [StringLength(2147483647)]
        public string GovernmentTierType { get; set; }

        public virtual BoostNames BoostNames { get; set; }

        public virtual GovernmentTiers GovernmentTiers { get; set; }

        public virtual GovernmentSlots GovernmentSlots { get; set; }

        public virtual Units Units { get; set; }

        public virtual Units Units1 { get; set; }

        public virtual Technologies Technologies { get; set; }

        public virtual Civics Civics { get; set; }

        public virtual Civics Civics1 { get; set; }

        public virtual Technologies Technologies1 { get; set; }

        public virtual Resources Resources { get; set; }

        public virtual Districts Districts { get; set; }

        public virtual Improvements Improvements { get; set; }

        public virtual Buildings Buildings { get; set; }
    }
}
