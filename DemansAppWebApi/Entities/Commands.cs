namespace DemansAppWebApi.Entities
{
    public class Commands
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public byte Status { get; set; }
        public int? UserId { get; set; }
        public int? CompanionId { get; set; }

    }
}
