using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatWelshsr.Models
{
    public class JobTitle
    {
        [DisplayName("Job Title ID")]
        public int JobTitleID { get; set; }

        [Required(ErrorMessage ="This field is required.")]
        [StringLength(30)]
        public string Title { get; set; }

        [DisplayName("Minimum Salary")]
        public int MinSalary { get; set; }

        [DisplayName("Maximum Salary")]
        public int MaxSalary { get; set; }

        [DisplayName("Position Filled?")]
        public bool IsFilled { get; set; } // Added

        [DisplayName("Degree Required")]
        [Required(ErrorMessage = "This field is required.")]
        [StringLength(30)]
        public string? DegreeTypeRequired { get; set; } // Added
        
        
        public List<Candidate> Candidates { get; set; }


    }
}
