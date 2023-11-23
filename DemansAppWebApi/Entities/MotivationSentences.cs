using System.ComponentModel.DataAnnotations;

namespace DemansAppWebApi.Entities
{
    public class MotivationSentences
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Text { get; set; }

        public int? UserId { get; set; }
        public Boolean Status { get; set; }
    }
}
