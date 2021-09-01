using Microsoft.AspNetCore.Identity;

namespace influencer.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string City { get; set; }
        public int UserCategory { get; set; }


    }
}
