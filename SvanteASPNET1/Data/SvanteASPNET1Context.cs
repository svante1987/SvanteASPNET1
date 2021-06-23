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

            Event[] events = new Event[] {
                new Event(){
                    Title="Rock helvetet",
                    Description="Satan vad varmt det är vid datorn",
                    Place="Stekpannestad",
                    Address="666 Helvetet",
                    Date=DateTime.Now.AddDays(34),
                    SpotsAvailable=666,
                    Organizer= organizers[0],
                },
                new Event(){
                    Title="Ölhimlen",
                    Description="Äntligen får du ta dig en öl",
                    Place="I paaaaken",
                    Address="Halland Halmstad Tre Öl å En Cidöh",
                    Date=DateTime.Now.AddDays(12),
                    SpotsAvailable=23,
                    Organizer= organizers[0],
                },
            };

            AddRange(attendees);
            AddRange(organizers);
            AddRange(events);

            SaveChanges();
        }

        public DbSet<SvanteASPNET1.Models.Attendee> Attendee { get; set; }
    }
}

