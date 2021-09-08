using Microsoft.AspNetCore.Identity;

namespace Domain.Entities.Context
{
    public class ApplicationUser : IdentityUser
    {
        public string City { get; set; }
        public int UserCategory { get; set; }


    }
}
