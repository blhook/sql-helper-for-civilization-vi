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

    public partial class RandomEvents
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RandomEvents()
        {
            CoastalLowlands = new HashSet<CoastalLowlands>();
            CoastalLowlands1 = new HashSet<CoastalLowlands>();
            RandomEvent_Damages = new HashSet<RandomEvent_Damages>();
            RandomEvent_Frequencies = new HashSet<RandomEvent_Frequencies>();
            RandomEvent_Yields = new HashSet<RandomEvent_Yields>();
            RandomEvent_PillagedImprovements = new HashSet<RandomEvent_PillagedImprovements>();
            RandomEvent_Terrains = new HashSet<RandomEvent_Terrains>();
        }

        [Key]
        [StringLength(2147483647)]
        public string RandomEventType { get; set; }

        [Required]
        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Name { get; set; }

        [Required]
        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Description { get; set; }

        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string EffectString { get; set; }

        public long Severity { get; set; }

        [StringLength(2147483647)]
        public string NaturalWonder { get; set; }

        public long IceLoss { get; set; }

        public long ClimateChangePoints { get; set; }

        public long ChanceIncreasePerDegree { get; set; }

        public long Hexes { get; set; }

        public long Movement { get; set; }

        public long Duration { get; set; }

        public long Spacing { get; set; }

        [StringLength(2147483647)]
        public string IconLarge { get; set; }

        [StringLength(2147483647)]
        public string IconSmall { get; set; }

        public long MinTurnAtRisk { get; set; }

        public long MitigatedYieldReduction { get; set; }

        [StringLength(2147483647)]
        public string EffectOperatorType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoastalLowlands> CoastalLowlands { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoastalLowlands> CoastalLowlands1 { get; set; }

        public virtual Features Features { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RandomEvent_Damages> RandomEvent_Damages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RandomEvent_Frequencies> RandomEvent_Frequencies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RandomEvent_Yields> RandomEvent_Yields { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RandomEvent_PillagedImprovements> RandomEvent_PillagedImprovements { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RandomEvent_Terrains> RandomEvent_Terrains { get; set; }
    }
}
