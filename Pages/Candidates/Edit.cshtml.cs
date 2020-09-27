using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RecruitCatWelshsr.Data;
using RecruitCatWelshsr.Models;

namespace RecruitCatWelshsr.Pages.Candidates
{
    public class EditModel : PageModel
    {
        private readonly RecruitCatWelshsr.Data.RecruitCatWelshsrContext _context;

        public EditModel(RecruitCatWelshsr.Data.RecruitCatWelshsrContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Candidate Candidate { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Candidate = await _context.Candidate
                .Include(c => c.Company)
                .Include(c => c.Industry).FirstOrDefaultAsync(m => m.CandidateId == id);

            if (Candidate == null)
            {
                return NotFound();
            }
           ViewData["CompanyId"] = new SelectList(_context.Set<Company>(), "CompanyID", "CompanyName");
           ViewData["IndustryId"] = new SelectList(_context.Set<Industry>(), "IndustryId", "Name");
           ViewData["JobTitleId"] = new SelectList(_context.Set<JobTitle>(), "JobTitleID", "Title");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Candidate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CandidateExists(Candidate.CandidateId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CandidateExists(int id)
        {
            return _context.Candidate.Any(e => e.CandidateId == id);
        }
    }
}
