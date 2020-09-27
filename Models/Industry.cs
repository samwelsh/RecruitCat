using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatWelshsr.Models
{
    public class Industry
    {
        [DisplayName("Industry ID #")]
        [Range(0, 999999999)] 
        public int IndustryId { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [StringLength(50)]
        public string Name { get; set; }
  
        public List<Candidate> Candidates { get; set; }

        public List<Company> Companies { get; set; }
    }
}
