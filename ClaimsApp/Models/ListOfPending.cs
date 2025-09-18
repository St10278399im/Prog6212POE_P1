namespace ClaimsApp.Models
{
    public class ListOfPending
    {
        public int ClaimId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public double HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }
        public string? Description { get; set; }
        public DateTime Date { get; set; }
        public string? SupportingDocumentPath { get; set; }
        public string Status { get; set; }
    }
}