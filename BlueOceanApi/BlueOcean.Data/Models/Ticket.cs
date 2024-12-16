﻿

namespace BlueOcean.Data.Models
{
    public class Ticket: BaseEntity
    {
        public string TicketTitle { get; set; }
        public string Reason { get; set; }
        public string Description { get; set; }

        public Guid UserId { get; set; }
        public virtual User User { get; set; }

    }
}
