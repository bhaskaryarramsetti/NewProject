using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EventManagement.Models;

namespace EventManagement.Data
{
    public class EventManagementContext : DbContext
    {
        public EventManagementContext (DbContextOptions<EventManagementContext> options)
            : base(options)
        {
        }

        public DbSet<EventManagement.Models.Event> Event { get; set; } = default!;
    }
}
