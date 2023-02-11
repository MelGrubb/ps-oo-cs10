using System.ComponentModel.DataAnnotations;

namespace Demo.Config
{
    internal class OtherSettings
    {
        public const string SectionName = "OtherSettings";

        public string StringSetting { get; set; } = null!;
        public int IntSetting { get; set; }
        public bool BoolSetting { get; set; }

        [Required]
        public DateTime? DateSetting { get; set; }
    }
}
