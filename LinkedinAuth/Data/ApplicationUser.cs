using Microsoft.AspNetCore.Identity;

namespace LinkedinAuth.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string PictureUrl { get; set; }
    }
}
