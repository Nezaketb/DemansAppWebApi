﻿namespace DemansAppWebApi.Entities
{
    public partial class Companions
    {
        public int Id { get; set; }

        public string Adress { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Phone { get; set; }

        public bool? Sex { get; set; }

        public int? UserId { get; set; }

        public int? Status { get; set; }

    }
}
