#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using pruebas_tickets.Models;

namespace pruebas_tickets.Data
{
    public class pruebas_ticketsContext : DbContext
    {
        public pruebas_ticketsContext (DbContextOptions<pruebas_ticketsContext> options)
            : base(options)
        {
        }

        public DbSet<pruebas_tickets.Models.Ticket> Ticket { get; set; }
    }
}
