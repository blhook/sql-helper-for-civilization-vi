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

    public partial class DiplomaticActions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DiplomaticActions()
        {
            DiplomaticStateActions = new HashSet<DiplomaticStateActions>();
        }

        [Key]
        [StringLength(2147483647)]
        public string DiplomaticActionType { get; set; }

        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Name { get; set; }

        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Description { get; set; }

        [StringLength(2147483647)]
        public string CivilopediaKey { get; set; }

        [StringLength(2147483647)]
        public string InitiatorPrereqCivic { get; set; }

        [StringLength(2147483647)]
        public string InitiatorPrereqTech { get; set; }

        [StringLength(2147483647)]
        public string TargetPrereqCivic { get; set; }

        [StringLength(2147483647)]
        public string TargetPrereqTech { get; set; }

        [StringLength(2147483647)]
        public string InitiatorObsoleteCivic { get; set; }

        public long Cost { get; set; }

        public bool RequiresCapitalPath { get; set; }

        public bool RequiresConvertedCity { get; set; }

        public bool RequiresOccupiedCity { get; set; }

        public bool RequiresOccupiedFriendlyCity { get; set; }

        public bool RequiresWarOnAlliedCityState { get; set; }

        public long RequiresLeadXEras { get; set; }

        public bool RequiresArchaeologyIntrusion { get; set; }

        public bool RequiresAdjacentEmpires { get; set; }

        public bool RequiresEspionageIntrusion { get; set; }

        public bool NoCurrentDelegation { get; set; }

        public bool NoCurrentEmbassy { get; set; }

        public bool NoCurrentOpenBorders { get; set; }

        public bool NoCurrentDenunciation { get; set; }

        public bool NoCurrentDOF { get; set; }

        public bool NoCurrentResearchAgreement { get; set; }

        public bool NoCurrentDefensivePact { get; set; }

        public bool Agreement { get; set; }

        public long WarmongerPercent { get; set; }

        public long CaptureWarmongerPercent { get; set; }

        public long RazeWarmongerPercent { get; set; }

        [StringLength(2147483647)]
        public string UIGroup { get; set; }

        public long DenouncementTurnsRequired { get; set; }

        public bool RequiresAlliance { get; set; }

        public bool RequiresTeamMembership { get; set; }

        public long Duration { get; set; }

        public virtual Civics Civics { get; set; }

        public virtual Civics Civics1 { get; set; }

        public virtual Civics Civics2 { get; set; }

        public virtual Types Types { get; set; }

        public virtual Technologies Technologies { get; set; }

        public virtual Technologies Technologies1 { get; set; }

        public virtual DiplomaticActions_XP1 DiplomaticActions_XP1 { get; set; }

        public virtual DiplomaticActions_XP2 DiplomaticActions_XP2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiplomaticStateActions> DiplomaticStateActions { get; set; }
    }
}
