using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitCatWelshsr.Models;

namespace RecruitCatWelshsr.Data
{
    public class RecruitCatWelshsrContext : DbContext
    {
        public RecruitCatWelshsrContext (DbContextOptions<RecruitCatWelshsrContext> options)
            : base(options)
        {
        }

        public DbSet<RecruitCatWelshsr.Models.Candidate> Candidate { get; set; }

        public DbSet<RecruitCatWelshsr.Models.Company> Company { get; set; }

        public DbSet<RecruitCatWelshsr.Models.Industry> Industry { get; set; }

        public DbSet<RecruitCatWelshsr.Models.JobTitle> JobTitle { get; set; }

    }
}
