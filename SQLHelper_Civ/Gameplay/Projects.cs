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

    public partial class Projects
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Projects()
        {
            EmergencyScoreSources = new HashSet<EmergencyScoreSources>();
            Project_BuildingCosts = new HashSet<Project_BuildingCosts>();
            Project_GreatPersonPoints = new HashSet<Project_GreatPersonPoints>();
            Project_ResourceCosts = new HashSet<Project_ResourceCosts>();
            Project_YieldConversions = new HashSet<Project_YieldConversions>();
            ProjectCompletionModifiers = new HashSet<ProjectCompletionModifiers>();
            ProjectPrereqs = new HashSet<ProjectPrereqs>();
            ProjectPrereqs1 = new HashSet<ProjectPrereqs>();
        }

        [Key]
        [StringLength(2147483647)]
        public string ProjectType { get; set; }

        [Required]
        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Name { get; set; }

        [Required]
        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string ShortName { get; set; }

        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Description { get; set; }

        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string PopupText { get; set; }

        public long Cost { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string CostProgressionModel { get; set; }

        public long CostProgressionParam1 { get; set; }

        [StringLength(2147483647)]
        public string PrereqTech { get; set; }

        [StringLength(2147483647)]
        public string PrereqCivic { get; set; }

        [StringLength(2147483647)]
        public string PrereqDistrict { get; set; }

        [StringLength(2147483647)]
        public string VisualBuildingType { get; set; }

        public bool SpaceRace { get; set; }

        public bool OuterDefenseRepair { get; set; }

        public long? MaxPlayerInstances { get; set; }

        public long? AmenitiesWhileActive { get; set; }

        [StringLength(2147483647)]
        public string PrereqResource { get; set; }

        [StringLength(2147483647)]
        public string AdvisorType { get; set; }

        public bool WMD { get; set; }

        public virtual Buildings Buildings { get; set; }

        public virtual Civics Civics { get; set; }

        public virtual Districts Districts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmergencyScoreSources> EmergencyScoreSources { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Project_BuildingCosts> Project_BuildingCosts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Project_GreatPersonPoints> Project_GreatPersonPoints { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Project_ResourceCosts> Project_ResourceCosts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Project_YieldConversions> Project_YieldConversions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectCompletionModifiers> ProjectCompletionModifiers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectPrereqs> ProjectPrereqs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectPrereqs> ProjectPrereqs1 { get; set; }

        public virtual Types Types { get; set; }

        public virtual Resources Resources { get; set; }

        public virtual Technologies Technologies { get; set; }

        public virtual Projects_XP1 Projects_XP1 { get; set; }

        public virtual Projects_XP2 Projects_XP2 { get; set; }
    }
}
