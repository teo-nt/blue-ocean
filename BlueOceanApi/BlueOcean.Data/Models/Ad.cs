using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueOcean.Data.Models
{
    public class Ad : BaseEntity
    {
        public virtual Boat Boat { get; set; }

        public string BoatId { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Amount { get; set; }

        public ICollection<Booking> Bookings { get; set; }
    }
}
