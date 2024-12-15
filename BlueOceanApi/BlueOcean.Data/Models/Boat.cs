using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BlueOcean.Data.Models
{
    public class Boat
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid BoatCategoryId { get; set; }

        [ForeignKey(nameof(BoatCategoryId))]
        public virtual BoatCategory? BoatCategory { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
    }
}
