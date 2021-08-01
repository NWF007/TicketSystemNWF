using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketSystemNWF.Data;
using TicketSystemNWF.Models;

namespace TicketSystemNWF.Repositories
{
    public class TicketPriorityRepository : ITicketPriorityRepository
    {
        private readonly ApplicationDbContext dbContext;

        public TicketPriorityRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public TicketPriority GetTicketPriority(int ticketID)
        {
            throw new NotImplementedException();
        }

        public void UpdateTicketPriority(int ticketID)
        {
            var ticket = dbContext.Tickets.FirstOrDefault(x => x.TicketId == ticketID);


        }
    }
}
