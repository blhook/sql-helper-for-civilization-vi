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

    public partial class Terrains
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Terrains()
        {
            Adjacency_YieldChanges = new HashSet<Adjacency_YieldChanges>();
            Buildings = new HashSet<Buildings>();
            Improvement_ValidTerrains = new HashSet<Improvement_ValidTerrains>();
            StartBiasTerrains = new HashSet<StartBiasTerrains>();
            Terrain_YieldChanges = new HashSet<Terrain_YieldChanges>();
            Building_ValidTerrains = new HashSet<Building_ValidTerrains>();
            District_ValidTerrains = new HashSet<District_ValidTerrains>();
            Feature_AdjacentTerrains = new HashSet<Feature_AdjacentTerrains>();
            Feature_NotAdjacentTerrains = new HashSet<Feature_NotAdjacentTerrains>();
            Feature_ValidTerrains = new HashSet<Feature_ValidTerrains>();
            Improvement_ValidAdjacentTerrains = new HashSet<Improvement_ValidAdjacentTerrains>();
            RandomEvent_Terrains = new HashSet<RandomEvent_Terrains>();
            Resource_ValidTerrains = new HashSet<Resource_ValidTerrains>();
            TerrainClass_Terrains = new HashSet<TerrainClass_Terrains>();
        }

        [Key]
        [StringLength(2147483647)]
        public string TerrainType { get; set; }

        [Required]
        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Name { get; set; }

        public bool Mountain { get; set; }

        public bool Hills { get; set; }

        public bool Water { get; set; }

        public long InfluenceCost { get; set; }

        public long MovementCost { get; set; }

        public bool ShallowWater { get; set; }

        public long SightModifier { get; set; }

        public long SightThroughModifier { get; set; }

        public bool Impassable { get; set; }

        public long DefenseModifier { get; set; }

        public long Appeal { get; set; }

        public long AntiquityPriority { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Adjacency_YieldChanges> Adjacency_YieldChanges { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Buildings> Buildings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Improvement_ValidTerrains> Improvement_ValidTerrains { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StartBiasTerrains> StartBiasTerrains { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Terrain_YieldChanges> Terrain_YieldChanges { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Building_ValidTerrains> Building_ValidTerrains { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<District_ValidTerrains> District_ValidTerrains { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Feature_AdjacentTerrains> Feature_AdjacentTerrains { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Feature_NotAdjacentTerrains> Feature_NotAdjacentTerrains { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Feature_ValidTerrains> Feature_ValidTerrains { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Improvement_ValidAdjacentTerrains> Improvement_ValidAdjacentTerrains { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RandomEvent_Terrains> RandomEvent_Terrains { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Resource_ValidTerrains> Resource_ValidTerrains { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TerrainClass_Terrains> TerrainClass_Terrains { get; set; }
    }
}
