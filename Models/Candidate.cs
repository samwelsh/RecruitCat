using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatWelshsr.Models
{
    public class Candidate
    {
        [DisplayName("Candidate ID")]
        [Range(0,999999999)] 
        public int CandidateId { get; set; }

        [DisplayName("First Name")]
        [Required(ErrorMessage ="This field is required.")]
        [StringLength(30)]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "This field is required.")]
        [StringLength(30)]
        public string LastName { get; set; }

        [DisplayName("Target Salary")]
        [Range(0,int.MaxValue)]
        public int TargetSalary { get; set; }

        [DisplayName("Social Security #")]
        [Range(100000000,999999999)] //Assuming SSN is a 9-digit integer
        public int SocialSecurityNum { get; set; }

        // Added:
        [DisplayName("Degree Type Held")]
        [Required(ErrorMessage = "This field is required.")]
        [StringLength(30)]
        public string? DegreeTypeHeld { get; set; }

        // Added: 
        [DisplayName("Date Available")]
        [DataType(DataType.Date)]
        public DateTime? DateAvailable { get; set; }

        [DisplayName("Company")]
        public int CompanyID { get; set; }
        public Company? Company { get; set; }

        [DisplayName("Industry")]
        public int IndustryID { get; set; }
        public Industry Industry { get; set; }

        [DisplayName("Job Title")]
        public int JobTitleID { get; set; }        
        public JobTitle JobTitle { get; set; }


    }
}
