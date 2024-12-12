using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueOcean.Data.Models
{
    public class Complain
    {
        public string TicketTitle { get; set; }
        public string Reason { get; set; }
        public string Description { get; set; }

        public Guid UserId { get; set; }
        public virtual User User { get; set; }
    }
}
