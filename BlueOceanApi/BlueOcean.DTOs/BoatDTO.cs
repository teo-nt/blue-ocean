using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueOcean.DTOs
{
    public class BoatDTO
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public int BoatCategoryName { get; set; }

        public string LocationName { get; set; }

        public string OwnerName { get; set; }

        public string AdTitle { get; set; }

        public string? ImageBase64 { get; set; }
    }
}
