using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SvanteASPNET1.Data
{
    public class MinDbContext : DbContext 
    {
        public MinDbContext (DbContextOptions<MinDbContext> options)
            : base(options)
        {

        }

        public DbSet<SvanteASPNET1.Models.Attendee> Attendee { get; set; }

        public DbSet<SvanteASPNET1.Models.Event> Event { get; set; }

        public DbSet<SvanteASPNET1.Models.Event> Organazier { get; set; }
    }
}
