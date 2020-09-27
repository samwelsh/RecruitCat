using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatWelshsr.Models
{
    public class Company
    {
        [DisplayName("Company Name")]
        [Required(ErrorMessage = "This field is required.")]
        [StringLength(50)]
        public string CompanyName { get; set; } 

        [DisplayName("Company ID")]
        [Range(0, 999999999)] 
        public int CompanyID { get; set; }

        [DisplayName("Job Title")]
        public int JobTitleID { get; set; }

        [DisplayName("Position Hiring For")]
        [Required(ErrorMessage = "This field is required.")]
        [StringLength(30)]
        public string JobTitle { get; set; }

        [DisplayName("Minimun Salary")]
        [Range(0,int.MaxValue)]
        public int MinSalary { get; set; }

        [DisplayName("Maximum Salary")]
        [Range(0,int.MaxValue)]
        public int MaxSalary { get; set; }

        [DisplayName("Start Date")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [StringLength(50)]
        public string Location { get; set; }

        [DisplayName("Employee Count")]
        [Range(0,9999999)]
        public int EmployeeCount { get; set; } // Added

        public List<Candidate> Candidates { get; set; }

        [DisplayName("Industry")]
        public int IndustryID { get; set; }
        public Industry Industry { get; set; }
    }
}
