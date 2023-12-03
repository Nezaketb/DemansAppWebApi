
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DemansAppWebApi.Entities
{
    public partial class Users
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string EmergencyPhone { get; set; }
        public string UserName { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public byte Sex { get; set; }
        public byte Status { get; set; }
    }
}
