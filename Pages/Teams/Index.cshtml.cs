using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SimpleSiteMSI.Data;
using SimpleSiteMSI.Models;

namespace SimpleSiteMSI.Pages.Teams
{
    public class IndexModel : PageModel
    {
        private readonly SimpleSiteMSI.Data.Context _context;

        public IndexModel(SimpleSiteMSI.Data.Context context)
        {
            _context = context;
        }

        public IList<Team> Team { get;set; }

        public async Task OnGetAsync()
        {
            Team = await _context.Team.ToListAsync();
        }
    }
}
