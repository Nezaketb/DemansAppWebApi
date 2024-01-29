using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemansAppWebApi.Entities
{
    public class Medicines
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? UsageDuration { get; set; }
        public bool Status { get; set; }
        public string? UsagePurpose { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool Moon { get; set; } = false;
        public bool Afternoon { get; set; } = false;
        public bool Evening { get; set; } = false;
        public bool Night { get; set; } = false;
        public string? MoonTime { get; set; }
        public string? AfternoonTime { get; set; }
        public string? EveningTime { get; set; }
        public string? NightTime { get; set; }
        public int UserId { get; set; }
    }
}
