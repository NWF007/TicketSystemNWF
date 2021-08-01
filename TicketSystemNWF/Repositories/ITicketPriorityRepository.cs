using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketSystemNWF.Models;

namespace TicketSystemNWF.Repositories
{
    public interface ITicketPriorityRepository
    {
        TicketPriority GetTicketPriority(int ticketID);
        void UpdateTicketPriority(int ticketID);
    }
}
