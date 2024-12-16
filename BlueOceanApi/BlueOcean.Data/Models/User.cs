using BlueOcean.Data.Enums;

namespace BlueOcean.Data.Models
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public  Role Role { get; set; }

        public ICollection<Boat> Boats { get; set; }

        public ICollection<Booking>? Bookings { get; set; }

        public ICollection<Complain> Complains { get; set; }

        public ICollection<Ticket> Tickets { get; set; }

    }
}
