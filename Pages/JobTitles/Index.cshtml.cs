using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatWelshsr.Data;
using RecruitCatWelshsr.Models;

namespace RecruitCatWelshsr.Pages.JobTitles
{
    public class IndexModel : PageModel
    {
        private readonly RecruitCatWelshsr.Data.RecruitCatWelshsrContext _context;

        public IndexModel(RecruitCatWelshsr.Data.RecruitCatWelshsrContext context)
        {
            _context = context;
        }

        public IList<JobTitle> JobTitle { get;set; }

        public async Task OnGetAsync()
        {
            JobTitle = await _context.JobTitle.ToListAsync();
        }
    }
}
