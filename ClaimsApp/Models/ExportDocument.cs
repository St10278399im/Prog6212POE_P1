namespace ClaimsApp.Models
{
    public class ExportDocument
    {
        public string SearchQuery { get; set; }

        public List<Claim> Claims { get; set; } = new List<Claim>();
    }
}