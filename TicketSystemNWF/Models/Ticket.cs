using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketSystemNWF.Models
{
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }

        [ForeignKey(nameof(TicketLogger)), Column(Order = 0)]
        public int LoggedBy { get; set; }

        [ForeignKey(nameof(Assignee)), Column(Order = 1)]
        public int AssignedTo { get; set; }
        public int ProjectId { get; set; }
        public int PriorityId { get; set; }
        public int TicketStatusId { get; set; }
        public string TicketDescription { get; set; }
        public DateTime TicketCreatedDate { get; set; }
        public DateTime TicketClosedDate { get; set; }
        public bool TicketClosed { get; set; }
        public DateTime TicketResolvedDate { get; set; }

        public virtual ApplicationUser TicketLogger { get; set; }
        public virtual ApplicationUser Assignee { get; set; }


        [ForeignKey("TicketStatusId")]
        public virtual TicketStatus TicketStatus { get; set; }

        [ForeignKey("ProjectId")]
        public virtual Project Project { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }

        [ForeignKey("PriorityId")]
        public virtual TicketPriority TicketPriority { get; set; }

        public virtual ICollection<TicketComment> TicketComments { get; set; }
        public virtual ICollection<TicketAttachment> TicketAttachments { get; set; }

    }
}