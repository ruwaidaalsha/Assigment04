using Assigment04.Models._01.Assigment04.Models._01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment04.Models._01
{

        public class Ticket
        {
            public string EventName { get; set; }
            public string SeatNumber { get; set; }
            public TicketType Type { get; set; }

            public Ticket(string eventName, string seatNumber, TicketType type)
            {
                EventName = eventName;
                SeatNumber = seatNumber;
                Type = type;
            }
        }
    }


