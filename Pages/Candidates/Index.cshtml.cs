using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatWelshsr.Data;
using RecruitCatWelshsr.Models;

namespace RecruitCatWelshsr.Pages.Candidates
{
    public class IndexModel : PageModel
    {
        private readonly RecruitCatWelshsr.Data.RecruitCatWelshsrContext _context;

        public IndexModel(RecruitCatWelshsr.Data.RecruitCatWelshsrContext context)
        {
            _context = context;
        }

        public IList<Candidate> Candidate { get;set; }

        public async Task OnGetAsync()
        {
            Candidate = await _context.Candidate
                .Include(c => c.Company)
                .Include(c => c.Industry).ToListAsync();
        }
    }
}
