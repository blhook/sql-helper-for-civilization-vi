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

    public partial class Adjacency_YieldChanges
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Adjacency_YieldChanges()
        {
            District_Adjacencies = new HashSet<District_Adjacencies>();
            ExcludedAdjacencies = new HashSet<ExcludedAdjacencies>();
            Improvement_Adjacencies = new HashSet<Improvement_Adjacencies>();
        }

        [Key]
        [StringLength(2147483647)]
        public string ID { get; set; }

        [Required]
        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Description { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string YieldType { get; set; }

        public long YieldChange { get; set; }

        public long TilesRequired { get; set; }

        public bool OtherDistrictAdjacent { get; set; }

        public bool AdjacentSeaResource { get; set; }

        [StringLength(2147483647)]
        public string AdjacentTerrain { get; set; }

        [StringLength(2147483647)]
        public string AdjacentFeature { get; set; }

        public bool AdjacentRiver { get; set; }

        public bool AdjacentWonder { get; set; }

        public bool AdjacentNaturalWonder { get; set; }

        [StringLength(2147483647)]
        public string AdjacentImprovement { get; set; }

        [StringLength(2147483647)]
        public string AdjacentDistrict { get; set; }

        [StringLength(2147483647)]
        public string PrereqCivic { get; set; }

        [StringLength(2147483647)]
        public string PrereqTech { get; set; }

        [StringLength(2147483647)]
        public string ObsoleteCivic { get; set; }

        [StringLength(2147483647)]
        public string ObsoleteTech { get; set; }

        public bool AdjacentResource { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string AdjacentResourceClass { get; set; }

        public bool Self { get; set; }

        public virtual Technologies Technologies { get; set; }

        public virtual Civics Civics { get; set; }

        public virtual Technologies Technologies1 { get; set; }

        public virtual Civics Civics1 { get; set; }

        public virtual Districts Districts { get; set; }

        public virtual Improvements Improvements { get; set; }

        public virtual Features Features { get; set; }

        public virtual Terrains Terrains { get; set; }

        public virtual Yields Yields { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<District_Adjacencies> District_Adjacencies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExcludedAdjacencies> ExcludedAdjacencies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Improvement_Adjacencies> Improvement_Adjacencies { get; set; }
    }
}
