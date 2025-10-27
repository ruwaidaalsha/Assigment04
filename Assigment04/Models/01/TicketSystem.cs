using Assigment04.Models._01.Assigment04.Models._01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Assigment04.Models._01
{
    public class TicketSystem
    {
       
            public List<Ticket> Tickets { get; set; } = new List<Ticket>();

            public void AddTicket(Ticket ticket)
            {
                Tickets.Add(ticket);
            }

            public Ticket this[string seatNumber]
            {
                get
                {
                    return Tickets.FirstOrDefault(t => t.SeatNumber == seatNumber);
                }
            }

            public void CountTicketsByType()
            {
                int regular = Tickets.Count(t => t.Type == TicketType.Regular);
                int vip = Tickets.Count(t => t.Type == TicketType.VIP);
                int backstage = Tickets.Count(t => t.Type == TicketType.Backstage);

                Console.WriteLine($"Regular Tickets: {regular}");
                Console.WriteLine($"VIP Tickets: {vip}");
                Console.WriteLine($"Backstage Tickets: {backstage}");
            }
        }
    }