using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemansAppWebApi.Entities
{
    public class MotivationSentences
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Text { get; set; }

        public int? UserId { get; set; }
        public Boolean Status { get; set; }
    }
}
