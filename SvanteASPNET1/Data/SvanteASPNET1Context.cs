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
        public SvanteASPNET1Context(DbContextOptions<SvanteASPNET1Context> options)
            : base(options)
        {
        }

        public DbSet<Event> Event { get; set; }

        public void Seed()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();

            Attendee[] attendees = new Attendee[] {
                new Attendee()
                {
                    Name = "Svante Vantesson",
                    PhoneNumber = "+46 123 456 71",
                    Email = "svantethevantesson@varsomhelst.se",
                },
            };

            Organizer[] organizers = new Organizer[] {
                new Organizer(){
                    Name = "RockMaskinen",
                    Email = "rock@maskin.se",
                    PhoneNumber = "46 666 666 66",
                },
            };
        }
    }
}

