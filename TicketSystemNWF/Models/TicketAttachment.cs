using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSystemNWF.Models
{
    public class TicketAttachment
    {
        [Key]
        public int AttachmentId { get; set; }
        public int TicketId { get; set; }
        public string AttachmentFileURL { get; set; }
        public string AttachmentFileName { get; set; }


        [ForeignKey("TicketId")]
        public virtual Ticket Ticket { get; set; }
    }
}
