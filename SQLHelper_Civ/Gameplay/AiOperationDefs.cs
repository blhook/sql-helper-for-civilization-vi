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

    public partial class AiOperationDefs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AiOperationDefs()
        {
            AiOperationTeams = new HashSet<AiOperationTeams>();
            AllowedOperations = new HashSet<AllowedOperations>();
            BoostHandlers = new HashSet<BoostHandlers>();
        }

        [Key]
        [StringLength(2147483647)]
        public string OperationName { get; set; }

        [Required]
        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string TargetType { get; set; }

        public long TargetParameter { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string EnemyType { get; set; }

        [StringLength(2147483647)]
        public string BehaviorTree { get; set; }

        public long Priority { get; set; }

        public long MaxTargetDistInRegion { get; set; }

        public long MaxTargetDistInArea { get; set; }

        public long MaxTargetDistInWorld { get; set; }

        public long MaxTargetStrength { get; set; }

        public long MaxTargetDefense { get; set; }

        [Column(TypeName = "real")]
        public double MinOddsOfSuccess { get; set; }

        public bool SelfStart { get; set; }

        public bool MustBeAtWar { get; set; }

        public bool MustHaveNukes { get; set; }

        public long MustHaveUnits { get; set; }

        [StringLength(2147483647)]
        public string OperationType { get; set; }

        public bool AllowTargetUpdate { get; set; }

        public virtual AiOperationTypes AiOperationTypes { get; set; }

        public virtual TargetTypes TargetTypes { get; set; }

        public virtual BehaviorTrees BehaviorTrees { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AiOperationTeams> AiOperationTeams { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AllowedOperations> AllowedOperations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BoostHandlers> BoostHandlers { get; set; }
    }
}
