namespace Test.ORM.Gameplay
{
    using SQLHelper_Civ.Globals;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Test.ORM.Localization;
    using static SQLHelper_Civ.Extensions_Helpers.Classes;

    public partial class DiplomacyStatements
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2147483647)]
        public string Type { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2147483647)]
        public string SubType { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2147483647)]
        public string Initiator { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(2147483647)]
        public string Leader { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(2147483647)]
        public string Mood { get; set; }

        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string StatementText { get; set; }

        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string ReasonText { get; set; }

        [StringLength(2147483647)]
        public string LeaderAnimation { get; set; }

        [StringLength(2147483647)]
        public string SceneEffect { get; set; }

        [StringLength(2147483647)]
        public string Selections { get; set; }
    }
}
