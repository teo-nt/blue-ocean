using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueOcean.Data.Models
{
    public class Location : BaseEntity
    {
        [Required]
        public string Area { get; set; }

        [Required]
        public string Port { get; set; }

        public ICollection <Boat> Boats { get; set; }
    }
}
