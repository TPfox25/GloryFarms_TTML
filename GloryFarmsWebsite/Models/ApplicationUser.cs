using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GloryFarmsWebsite.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
