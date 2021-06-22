using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SvanteASPNET1.Models;

namespace SvanteASPNET1.Data
{
    public class SvanteASPNET1Context : DbContext
    {
        public SvanteASPNET1Context (DbContextOptions<SvanteASPNET1Context> options)
            : base(options)
        {
        }

        public DbSet<SvanteASPNET1.Models.Event> Event { get; set; }
    }
}
