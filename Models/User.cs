using Microsoft.AspNetCore.Identity;

namespace Sashiel_ST10028058_CLDV6212_POE.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
