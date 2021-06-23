using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SvanteASPNET1.Data;
using SvanteASPNET1.Models;

namespace SvanteASPNET1.Pages
{
    public class JoinEventModel : PageModel
    {
        private readonly SvanteASPNET1.Data.SvanteASPNET1Context _context;

        public JoinEventModel(SvanteASPNET1.Data.SvanteASPNET1Context context)
        {
            _context = context;
        }

        public Event Event { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Event = await _context.Event.FirstOrDefaultAsync(m => m.Id == id);

            if (Event == null)
            {
                return NotFound();
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Event = await _context.Event.Include(e => e.Attendees).FirstOrDefaultAsync(m => m.Id == id);

            if (Event == null)
            {
                return NotFound();
            }

            var attendee = await _context.Attendee.FirstOrDefaultAsync();

            if (!Event.Attendees.Contains(attendee))
            {
                Event.Attendees.Add(attendee);
                await _context.SaveChangesAsync();
            }

            return Page();
        }
    }
}
