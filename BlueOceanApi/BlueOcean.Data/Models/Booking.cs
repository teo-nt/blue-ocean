using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueOcean.Data.Models
{
    public class Booking : BaseEntity
    {
        public Guid? UserId { get; set; }
        public User? User { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
        public Ad? Ad { get; set; }

        public Guid AdId { get; set; }
    }
}
