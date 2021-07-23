using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSystemNWF.Models
{
    public class TicketPriority
    {
        [Key]
        public int PriorityId { get; set; }
        public string Description { get; set; }
    }
}
