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
    using System.ComponentModel.DataAnnotations.Schema;
    using Test.ORM.Localization;
    using static SQLHelper_Civ.Extensions_Helpers.Classes;

    public partial class Civilizations
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Civilizations()
        {
            CityNames = new HashSet<CityNames>();
            CivilizationCitizenNames = new HashSet<CivilizationCitizenNames>();
            CivilizationInfo = new HashSet<CivilizationInfo>();
            CivilizationLeaders = new HashSet<CivilizationLeaders>();
            FavoredReligions = new HashSet<FavoredReligions>();
            StartBiasFeatures = new HashSet<StartBiasFeatures>();
            StartBiasResources = new HashSet<StartBiasResources>();
            StartBiasTerrains = new HashSet<StartBiasTerrains>();
            CivilizationTraits = new HashSet<CivilizationTraits>();
            DuplicateCivilizations1 = new HashSet<DuplicateCivilizations>();
            DuplicateCivilizations2 = new HashSet<DuplicateCivilizations>();
            NamedDesertCivilizations = new HashSet<NamedDesertCivilizations>();
            NamedMountainCivilizations = new HashSet<NamedMountainCivilizations>();
            NamedRiverCivilizations = new HashSet<NamedRiverCivilizations>();
            NamedVolcanoCivilizations = new HashSet<NamedVolcanoCivilizations>();
        }

        [Key]
        [StringLength(2147483647)]
        public string CivilizationType { get; set; }

        [Required]
        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(EnglishText.Tag))]
        public string Name { get; set; }

        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(EnglishText.Tag))]
        public string Description { get; set; }

        [Required]
        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Adjective { get; set; }

        public long RandomCityNameDepth { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string StartingCivilizationLevelType { get; set; }

        [StringLength(2147483647)]
        public string Ethnicity { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CityNames> CityNames { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CivilizationCitizenNames> CivilizationCitizenNames { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CivilizationInfo> CivilizationInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CivilizationLeaders> CivilizationLeaders { get; set; }

        public virtual CivilizationLevels CivilizationLevels { get; set; }

        public virtual Types Types { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FavoredReligions> FavoredReligions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StartBiasFeatures> StartBiasFeatures { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StartBiasResources> StartBiasResources { get; set; }

        public virtual StartBiasRivers StartBiasRivers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StartBiasTerrains> StartBiasTerrains { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CivilizationTraits> CivilizationTraits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [InverseProperty(nameof(DuplicateCivilizations.CivilizationTypeNavigation))]
        public virtual ICollection<DuplicateCivilizations> DuplicateCivilizations1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [InverseProperty(nameof(DuplicateCivilizations.OtherCivilizationTypeNavigation))]
        public virtual ICollection<DuplicateCivilizations> DuplicateCivilizations2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NamedDesertCivilizations> NamedDesertCivilizations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NamedMountainCivilizations> NamedMountainCivilizations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NamedRiverCivilizations> NamedRiverCivilizations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NamedVolcanoCivilizations> NamedVolcanoCivilizations { get; set; }
    }
}
