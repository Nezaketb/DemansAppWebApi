﻿
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DemansAppWebApi.Entities
{
    public partial class Users
    {
        [Key]
        public int Id { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? EmergencyPhone { get; set; }
        public string? UserName { get; set; }
        public string? Surname { get; set; }
        public string? Phone { get; set; }
        public bool Sex { get; set; }
        public int? Status { get; set; }
    }
}
