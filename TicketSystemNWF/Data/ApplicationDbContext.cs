using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TicketSystemNWF.Models;

namespace TicketSystemNWF.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketPriority> Priorities { get; set; }
        public DbSet<TicketAttachment> Attachments { get; set; }
        public DbSet<TicketComment> Comments { get; set; }
        public DbSet<TicketStatus> Statuses { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
