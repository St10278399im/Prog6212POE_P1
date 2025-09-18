using System.ComponentModel.DataAnnotations;

namespace ClaimsApp.Models
{
    public class NewClaim
    {
        [Display(Name = "Claim ID")]
        [Required(ErrorMessage = "Claim ID is required")]
        public int ClaimId { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First name is required")]
        [StringLength(50, ErrorMessage = "First name cannot exceed 50 characters")]
        public string Name { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last name is required")]
        [StringLength(50, ErrorMessage = "Last name cannot exceed 50 characters")]
        public string Surname { get; set; }

        [Display(Name = "Hours Worked")]
        [Required(ErrorMessage = "Hours worked is required")]
        [Range(1, 1000, ErrorMessage = "Please enter a valid number of hours between 0.1 and 1000")]
        public double HoursWorked { get; set; }

        [Display(Name = "Hourly Rate (£)")]
        [Required(ErrorMessage = "Hourly rate is required")]
        [Range(0.01, 1000, ErrorMessage = "Please enter a valid hourly rate between 0.01 and 1000")]
        [DataType(DataType.Currency)]
        public decimal HourlyRate { get; set; }

        [Display(Name = "Description")]
        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters")]
        public string Description { get; set; }

        [Display(Name = "Date")]
        [Required(ErrorMessage = "Date is required")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}
