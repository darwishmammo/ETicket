﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public int SeatId { get; set; }
        public int EventId { get; set; }
        public int CustomerId { get; set; }
    }
}