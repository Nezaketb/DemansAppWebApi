namespace DemansAppWebApi.Entities
{
    public partial class LocationInformation
    {
        public int Id { get; set; }

        public string Lat { get; set; }

        public string Lng { get; set; }

        public int? UserId { get; set; }
        public Boolean Status { get; set; }

    }
}
