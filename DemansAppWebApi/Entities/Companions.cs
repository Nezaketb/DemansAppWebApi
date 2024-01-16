using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DemansAppWebApi.Entities
{
    public partial class Companions
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string? Adress { get; set; }

        public string? Email { get; set; }

        public string? Name { get; set; }

        public string? Surname { get; set; }

        public string? Phone { get; set; }

        public bool Sex { get; set; }

        public int? UserId { get; set; }

        public int? Status { get; set; }

    }
}
