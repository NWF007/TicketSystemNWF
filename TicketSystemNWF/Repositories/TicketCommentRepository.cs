using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketSystemNWF.Data;
using TicketSystemNWF.Models;

namespace TicketSystemNWF.Repositories
{
    public class TicketCommentRepository : ITicketCommentRepository
    {
        private readonly ApplicationDbContext dbContext;

        public TicketCommentRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void AddComment(TicketComment comment)
        {
            dbContext.Comments.Add(comment);

            try
            {
                dbContext.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }

        public void DeleteComment(int commentID)
        {
            var comment = dbContext.Comments.FirstOrDefault(x => x.TicketCommentId == commentID);

            dbContext.Comments.Remove(comment);
            try
            {
                dbContext.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }

        public void EditComment(TicketComment ticketComment)
        {
            dbContext.Entry(ticketComment).State = EntityState.Modified;
            try
            {
                dbContext.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }

        public IEnumerable<TicketComment> GetTicketComments(int ticketID)
        {
            return dbContext.Comments.Where(x => x.TicketId == ticketID);
        }
    }
}
