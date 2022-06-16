namespace Test.ORM.Gameplay
{
    using SQLHelper_Civ.Globals;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Test.ORM.Localization;
    using static SQLHelper_Civ.Extensions_Helpers.Classes;

    public partial class DiplomacySelections
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2147483647)]
        public string Type { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2147483647)]
        public string Leader { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Mood { get; set; }

        public long? Sort { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2147483647)]
        public string Key { get; set; }

        [Required]
        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Text { get; set; }

        [StringLength(2147483647)]
        [CrossContextForeignKey(Globals.LocalizationName, nameof(LocalizedText), nameof(LocalizedText.Tag))]
        public string Tooltip { get; set; }

        [StringLength(2147483647)]
        public string DiplomaticActionType { get; set; }
    }
}
