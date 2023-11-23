
namespace DemansAppWebApi.Entities
{
    public partial class Users
    {
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
