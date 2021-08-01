using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketSystemNWF.Data;
using TicketSystemNWF.Models;

namespace TicketSystemNWF.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        private readonly ApplicationDbContext dbContext;

        public TicketRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void CloseTicket(int ticketID)
        {
            var ticket = dbContext.Tickets.FirstOrDefault(x => x.TicketId == ticketID);
            ticket.TicketClosed = true;
            ticket.TicketClosedDate = DateTime.Now;
            //dbContext.Tickets.Update(ticket);
            dbContext.Entry(ticket).State = EntityState.Modified;

            try
            {
                dbContext.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }

        public void CreateTicket(Ticket ticket)
        {
            dbContext.Tickets.Add(ticket);
            try
            {
                dbContext.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }

        public Ticket GetTicketByID(int ticketID)
        {
            return dbContext.Tickets.FirstOrDefault(x => x.TicketId == ticketID);
        }

        public IEnumerable<Ticket> GetTicketsBycustomer(string userID)
        {
            return dbContext.Tickets.Where(x => x.LoggedBy == userID);
        }

        public IEnumerable<Ticket> GetTicketsByProject(int projectID)
        {
            return dbContext.Tickets.Where(x => x.ProjectId == projectID);
        }

        public IEnumerable<Ticket> GetTicketsByUser(string userID)
        {
            return dbContext.Tickets.Where(x => x.AssignedTo == userID);
        }

        public void UpdateTicket(Ticket ticket)
        {
            dbContext.Entry(ticket).State = EntityState.Modified;
            try
            {
                dbContext.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }
    }
}
