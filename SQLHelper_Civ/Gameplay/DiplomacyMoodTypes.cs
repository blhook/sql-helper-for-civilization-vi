namespace Test.ORM.Gameplay
{
    using System.ComponentModel.DataAnnotations;

    public partial class DiplomacyMoodTypes
    {
        [Key]
        [StringLength(2147483647)]
        public string Type { get; set; }
    }
}
