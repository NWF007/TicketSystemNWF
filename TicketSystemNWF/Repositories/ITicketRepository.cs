using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketSystemNWF.Models;

namespace TicketSystemNWF.Repositories
{
    public interface ITicketRepository
    {
        IEnumerable<Ticket> GetTicketsByUser(string userID);
        IEnumerable<Ticket> GetTicketsByProject(int projectID);
        IEnumerable<Ticket> GetTicketsBycustomer(string userID);
        Ticket GetTicketByID(int ticketID);
        void CreateTicket(Ticket ticket);
        void UpdateTicket(Ticket ticket);
        void CloseTicket(int ticketID);

    }
}
