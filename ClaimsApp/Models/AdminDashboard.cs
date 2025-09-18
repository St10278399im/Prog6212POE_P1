using System.Security.Claims;

namespace ClaimsApp.Models
{
    public class AdminDashboard
    {
        public string SearchQuery { get; set; }
        public List<Claim> SearchResults { get; set; }
        public string LoggedInAdmin { get; set; } // Optional
    }
}