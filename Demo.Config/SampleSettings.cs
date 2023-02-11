using System.ComponentModel.DataAnnotations;

namespace Demo.Config
{
    internal class SampleSettings
    {
        public const string SectionName = "SampleSettings";

        public string StringSetting { get; set; } = null!;
        public int IntSetting { get; set; }
        public bool BoolSetting { get; set; }

        [Required]
        public DateTime? DateSetting { get; set; }
    }
}
