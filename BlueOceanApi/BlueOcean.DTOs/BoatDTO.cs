using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueOcean.DTOs
{
    public class BoatDTO
    {
        public string? Id { get; set; }

        public string Name { get; set; }

        public int BoatCategory { get; set; }

        public string Port { get; set; }

        public OwnerDTO Owner { get; set; }

        public Byte[]? Image { get; set; }
    }
}
