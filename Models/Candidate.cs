using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Lab3MidtermReview.Models
{
    public class Candidate
    {
        //ID, FirstName & Lastname
        [Key]
        public int CandidateId { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "Maximum Candidate first name 20 char")]
        [DisplayName("Candidate First Name")]
        public string CandidateFirst { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "Maximum Candidate first name 20 char")]
        [DisplayName("Candidate Last Name")]
        public string CandidateLast { get; set; }
        [Required]
        [DisplayName("Candidate ID Number")]
        public string Candidatenum { get; set; }


    }
}
