using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueOcean.Data.Models
{
    public class Complain : BaseEntity
    {
        public string Name { get; set; }
        public string Reason { get; set; }
        public string Description { get; set; }

        public string UserId { get; set; }
        public virtual User User { get; set; }
    }
}
