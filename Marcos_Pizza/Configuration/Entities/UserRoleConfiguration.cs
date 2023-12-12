using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Marcos_Pizza.Web.Configuration.Entities
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
       public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    //RoleId = "e8b43kb8-ad6b-4a8e-949c-a5d14312c1ca",
                    //UserId= "e9b43bb8-ad2c-4a8e-949c-a4d14313c1cf"
                },

                 new IdentityUserRole<string>
                 {
                     //    RoleId = "be70bfb-3812-4b96-b42d-66d7ed5baf5f",
                     //    UserId = "e9b43ab8-ad6b-4a8e-949c-a4d14312c1ca"
                 }

                );

        }
    }
}