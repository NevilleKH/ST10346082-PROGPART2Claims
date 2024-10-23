using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class AddClaimViewModel
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        [Required]
        public int HoursWorked { get; set; }
        [Required]
        public int HourlyRate { get; set; }

        public int TotalAmount { get; set; }

        public string ClaimStatus { get; set; }
    }
}
