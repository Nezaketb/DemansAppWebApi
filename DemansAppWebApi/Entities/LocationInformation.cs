using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DemansAppWebApi.Entities
{
    public partial class LocationInformation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public decimal? Lat { get; set; }

        public decimal? Lng { get; set; }

        public int? UserId { get; set; }
        public Boolean? Status { get; set; }

    }
}
