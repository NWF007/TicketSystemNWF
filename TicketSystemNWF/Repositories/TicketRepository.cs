using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketSystemNWF.Models;

namespace TicketSystemNWF.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        public void CloseTicket(int ticketID)
        {
            throw new NotImplementedException();
        }

        public void CreateTicket(Ticket ticket)
        {
            throw new NotImplementedException();
        }

        public Ticket GetTicketByID(int ticketID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Ticket> GetTicketsBycustomer(string userID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Ticket> GetTicketsByProject(int projectID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Ticket> GetTicketsByUser(string userID)
        {
            throw new NotImplementedException();
        }

        public void UpdateTicket(Ticket ticket)
        {
            throw new NotImplementedException();
        }
    }
}
