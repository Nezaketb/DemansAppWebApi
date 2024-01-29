using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DemansAppWebApi.Entities
{
    public class Pictures
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string? Text { get; set; }

        public string? Url { get; set; }

        public int UserId { get; set; }
    }
}
