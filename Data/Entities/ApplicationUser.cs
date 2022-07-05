using Microsoft.AspNetCore.Identity;

namespace AuthBooter.Data.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            FirstName = "First";
            LastName = "Last";
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
