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

    public partial class Leaders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Leaders()
        {
            AgendaPreferredLeaders = new HashSet<AgendaPreferredLeaders>();
            CityNames = new HashSet<CityNames>();
            CivilizationLeaders = new HashSet<CivilizationLeaders>();
            FavoredReligions = new HashSet<FavoredReligions>();
            LeaderInfo = new HashSet<LeaderInfo>();
            LeaderQuotes = new HashSet<LeaderQuotes>();
            Leaders1 = new HashSet<Leaders>();
            DuplicateLeaders1 = new HashSet<DuplicateLeaders>();
            DuplicateLeaders2 = new HashSet<DuplicateLeaders>();
            HistoricalAgendas = new HashSet<HistoricalAgendas>();
            LeaderTraits = new HashSet<LeaderTraits>();
        }

        [Key]
        [StringLength(2147483647)]
        public string LeaderType { get; set; }

        [Required]
        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Name { get; set; }

        [StringLength(2147483647)]
        public string OperationList { get; set; }

        public bool IsBarbarianLeader { get; set; }

        [StringLength(2147483647)]
        public string InheritFrom { get; set; }

        public long SceneLayers { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Sex { get; set; }

        public long SameSexPercentage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AgendaPreferredLeaders> AgendaPreferredLeaders { get; set; }

        public virtual AiOperationLists AiOperationLists { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CityNames> CityNames { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CivilizationLeaders> CivilizationLeaders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FavoredReligions> FavoredReligions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeaderInfo> LeaderInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeaderQuotes> LeaderQuotes { get; set; }

        public virtual Types Types { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Leaders> Leaders1 { get; set; }

        public virtual Leaders Leaders2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [InverseProperty(nameof(DuplicateLeaders.LeaderTypeNavigation))]
        public virtual ICollection<DuplicateLeaders> DuplicateLeaders1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [InverseProperty(nameof(DuplicateLeaders.OtherLeaderTypeNavigation))]
        public virtual ICollection<DuplicateLeaders> DuplicateLeaders2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistoricalAgendas> HistoricalAgendas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeaderTraits> LeaderTraits { get; set; }
    }
}
