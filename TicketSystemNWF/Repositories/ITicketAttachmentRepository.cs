using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketSystemNWF.Models;

namespace TicketSystemNWF.Repositories
{
    public interface ITicketAttachmentRepository
    {
        void AddAttachment(TicketAttachment attachment);
        void UpdateAttachment(TicketAttachment attachment);
        void DeleteAttachment(int attachmentID);
        TicketAttachment GetAttachment(int attachmentID);
    }
}
