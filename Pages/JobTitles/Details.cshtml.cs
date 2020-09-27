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
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatWelshsr.Data.RecruitCatWelshsrContext _context;

        public DetailsModel(RecruitCatWelshsr.Data.RecruitCatWelshsrContext context)
        {
            _context = context;
        }

        public JobTitle JobTitle { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            JobTitle = await _context.JobTitle.FirstOrDefaultAsync(m => m.JobTitleID == id);

            if (JobTitle == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
