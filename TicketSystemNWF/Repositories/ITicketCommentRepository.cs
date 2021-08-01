using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketSystemNWF.Models;

namespace TicketSystemNWF.Repositories
{
    public interface ITicketCommentRepository
    {
        void AddComment(TicketComment comment);
        IEnumerable<TicketComment> GetTicketComments(int ticketID);
        void EditComment(TicketComment ticketComment);
        void DeleteComment();
    }
}
