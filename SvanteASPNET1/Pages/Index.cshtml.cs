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
    public class IndexModel : PageModel
    {
        private readonly SvanteASPNET1.Data.SvanteASPNET1Context _context;

        public IndexModel(SvanteASPNET1.Data.SvanteASPNET1Context context)
        {
            _context = context;
        }

        public IList<Event> Event { get;set; }

        public async Task OnGetAsync()
        {
            Event = await _context.Event.ToListAsync();
        }
    }
}
