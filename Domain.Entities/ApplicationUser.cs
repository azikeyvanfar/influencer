using Microsoft.AspNetCore.Identity;

namespace Domain.Entities.Context
{
    public class ApplicationUser : IdentityUser
    {
        public string City { get; set; }
        public int UserCategory { get; set; }


        /**Start Blogger*/
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Country { get; set; }

        public string InstagramPage { get; set; }

        public int? ApproximatePrice { get; set; }

        public string YourFavourites { get; set; }

        public string AnythingElse { get; set; }

        public string YourPicture { get; set; }
       
        public string CompanyName { get; set; }

        public string Brand { get; set; }

        public string ProductsServices { get; set; }

        public int? ApproximateBudget { get; set; }

        public string CountryOfOrigin { get; set; }

        public string DestinationCountries { get; set; }

    }
}
