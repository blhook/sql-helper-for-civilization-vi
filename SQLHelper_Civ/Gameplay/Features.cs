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

    public partial class Features
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Features()
        {
            Adjacency_YieldChanges = new HashSet<Adjacency_YieldChanges>();
            Feature_AdjacentYields = new HashSet<Feature_AdjacentYields>();
            Feature_Removes = new HashSet<Feature_Removes>();
            Feature_YieldChanges = new HashSet<Feature_YieldChanges>();
            GreatPersonIndividuals = new HashSet<GreatPersonIndividuals>();
            RandomEvent_Yields = new HashSet<RandomEvent_Yields>();
            RandomEvents = new HashSet<RandomEvents>();
            StartBiasFeatures = new HashSet<StartBiasFeatures>();
            Building_RequiredFeatures = new HashSet<Building_RequiredFeatures>();
            Building_ValidFeatures = new HashSet<Building_ValidFeatures>();
            District_RequiredFeatures = new HashSet<District_RequiredFeatures>();
            Feature_AdjacentFeatures1 = new HashSet<Feature_AdjacentFeatures>();
            Feature_AdjacentFeatures2 = new HashSet<Feature_AdjacentFeatures>();
            Feature_AdjacentTerrains = new HashSet<Feature_AdjacentTerrains>();
            Feature_NotAdjacentTerrains = new HashSet<Feature_NotAdjacentTerrains>();
            Feature_NotNearFeatures1 = new HashSet<Feature_NotNearFeatures>();
            Feature_NotNearFeatures2 = new HashSet<Feature_NotNearFeatures>();
            Feature_ValidTerrains = new HashSet<Feature_ValidTerrains>();
            Improvement_InvalidAdjacentFeatures = new HashSet<Improvement_InvalidAdjacentFeatures>();
            Improvement_ValidFeatures = new HashSet<Improvement_ValidFeatures>();
            Resource_ValidFeatures = new HashSet<Resource_ValidFeatures>();
        }

        [Key]
        [StringLength(2147483647)]
        public string FeatureType { get; set; }

        [Required]
        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Name { get; set; }

        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Description { get; set; }

        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Quote { get; set; }

        public bool Coast { get; set; }

        public bool NoCoast { get; set; }

        public bool NoRiver { get; set; }

        public bool NoAdjacentFeatures { get; set; }

        public bool RequiresRiver { get; set; }

        public long MovementChange { get; set; }

        public long SightThroughModifier { get; set; }

        public bool Impassable { get; set; }

        public bool NaturalWonder { get; set; }

        [StringLength(2147483647)]
        public string RemoveTech { get; set; }

        public bool Removable { get; set; }

        [StringLength(2147483647)]
        public string AddCivic { get; set; }

        public long DefenseModifier { get; set; }

        public bool AddsFreshWater { get; set; }

        public long Appeal { get; set; }

        public long MinDistanceLand { get; set; }

        public long MaxDistanceLand { get; set; }

        public bool NotNearFeature { get; set; }

        public bool Lake { get; set; }

        public long Tiles { get; set; }

        public bool Adjacent { get; set; }

        public bool NoResource { get; set; }

        public bool DoubleAdjacentTerrainYield { get; set; }

        public bool NotCliff { get; set; }

        public long MinDistanceNW { get; set; }

        [StringLength(2147483647)]
        public string CustomPlacement { get; set; }

        public bool Forest { get; set; }

        public long AntiquityPriority { get; set; }

        [StringLength(2147483647)]
        public string QuoteAudio { get; set; }

        public bool Settlement { get; set; }

        public bool FollowRulesInWB { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Adjacency_YieldChanges> Adjacency_YieldChanges { get; set; }

        public virtual Civics Civics { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Feature_AdjacentYields> Feature_AdjacentYields { get; set; }

        public virtual Feature_Floodplains Feature_Floodplains { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Feature_Removes> Feature_Removes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Feature_YieldChanges> Feature_YieldChanges { get; set; }

        public virtual Types Types { get; set; }

        public virtual Technologies Technologies { get; set; }

        public virtual Features_XP2 Features_XP2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GreatPersonIndividuals> GreatPersonIndividuals { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RandomEvent_Yields> RandomEvent_Yields { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RandomEvents> RandomEvents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StartBiasFeatures> StartBiasFeatures { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Building_RequiredFeatures> Building_RequiredFeatures { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Building_ValidFeatures> Building_ValidFeatures { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<District_RequiredFeatures> District_RequiredFeatures { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [InverseProperty(nameof(Feature_AdjacentFeatures.FeatureTypeNavigation))]
        public virtual ICollection<Feature_AdjacentFeatures> Feature_AdjacentFeatures1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [InverseProperty(nameof(Feature_AdjacentFeatures.FeatureTypeAdjacentNavigation))]
        public virtual ICollection<Feature_AdjacentFeatures> Feature_AdjacentFeatures2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Feature_AdjacentTerrains> Feature_AdjacentTerrains { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Feature_NotAdjacentTerrains> Feature_NotAdjacentTerrains { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [InverseProperty(nameof(Feature_NotNearFeatures.FeatureTypeAvoidNavigation))]
        public virtual ICollection<Feature_NotNearFeatures> Feature_NotNearFeatures1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [InverseProperty(nameof(Feature_NotNearFeatures.FeatureTypeNavigation))]
        public virtual ICollection<Feature_NotNearFeatures> Feature_NotNearFeatures2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Feature_ValidTerrains> Feature_ValidTerrains { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Improvement_InvalidAdjacentFeatures> Improvement_InvalidAdjacentFeatures { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Improvement_ValidFeatures> Improvement_ValidFeatures { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Resource_ValidFeatures> Resource_ValidFeatures { get; set; }
    }
}
