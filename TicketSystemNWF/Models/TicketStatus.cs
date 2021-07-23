using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSystemNWF.Models
{
    public class TicketStatus
    {
        [Key]
        public int TicketStatusId { get; set; }
        public string Description { get; set; }
    }
}
