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

    public partial class GreatPersonClasses
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GreatPersonClasses()
        {
            Building_GreatPersonPoints = new HashSet<Building_GreatPersonPoints>();
            District_CitizenGreatPersonPoints = new HashSet<District_CitizenGreatPersonPoints>();
            District_GreatPersonPoints = new HashSet<District_GreatPersonPoints>();
            EmergencyScoreSources = new HashSet<EmergencyScoreSources>();
            GreatPersonIndividuals = new HashSet<GreatPersonIndividuals>();
            Map_GreatPersonClasses = new HashSet<Map_GreatPersonClasses>();
            //ObsoletePolicies = new HashSet<ObsoletePolicies>();
            Project_GreatPersonPoints = new HashSet<Project_GreatPersonPoints>();
            ExcludedGreatPersonClasses = new HashSet<ExcludedGreatPersonClasses>();
        }

        [Key]
        [StringLength(2147483647)]
        public string GreatPersonClassType { get; set; }

        [Required]
        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Name { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string UnitType { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string DistrictType { get; set; }

        public long? MaxPlayerInstances { get; set; }

        [StringLength(2147483647)]
        public string PseudoYieldType { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string IconString { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string ActionIcon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Building_GreatPersonPoints> Building_GreatPersonPoints { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<District_CitizenGreatPersonPoints> District_CitizenGreatPersonPoints { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<District_GreatPersonPoints> District_GreatPersonPoints { get; set; }

        public virtual Districts Districts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmergencyScoreSources> EmergencyScoreSources { get; set; }

        public virtual Types Types { get; set; }

        public virtual PseudoYields PseudoYields { get; set; }

        public virtual Units Units { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GreatPersonIndividuals> GreatPersonIndividuals { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Map_GreatPersonClasses> Map_GreatPersonClasses { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ObsoletePolicies> ObsoletePolicies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Project_GreatPersonPoints> Project_GreatPersonPoints { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExcludedGreatPersonClasses> ExcludedGreatPersonClasses { get; set; }
    }
}
