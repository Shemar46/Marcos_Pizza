using Microsoft.AspNetCore.Identity;

namespace Marcos_Pizza.Data
{
    public class User : IdentityUser
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? gender { get; set; }

        


    }
}
