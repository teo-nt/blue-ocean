using BlueOcean.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;


namespace BlueOcean.Data.Models
{
    public class Boat : BaseEntity
    {

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required]
        public BoatCategory BoatCategory { get; set; }

        [Required]
        public Byte[] Image { get; set; }

        public virtual Location Location { get; set; }

        public Guid LocationId { get; set; }

        public virtual User Owner { get; set; }

        public Guid OwnerId { get; set; }

    }
}
