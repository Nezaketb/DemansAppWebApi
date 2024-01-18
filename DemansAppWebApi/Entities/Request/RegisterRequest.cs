using System;
namespace DemansAppWebApi.Entities.Request
{
	public class RegisterRequest
	{
        public string UserName { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string EmergencyPhone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}

