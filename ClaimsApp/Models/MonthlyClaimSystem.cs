using System.Security.Claims;

namespace ClaimsApp.Models
{
    public class MonthlyClaimSystem
    {
        public string SearchQuery { get; set; }

        // Optional: claims that match the search
        public List<Claim> SearchResults { get; set; }

        // Optional: current user's name or role
        public string LoggedInUser { get; set; }
    }
}