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
                    RoleId = "43cb8c89-9172-46b6-aa72-e2e7dc12cf49",
                    UserId = "43cb8c89-9172-46b6-aa72-f2e7bc12cf49"
                },

                 new IdentityUserRole<string>
                 {
                     RoleId = "c6a02c66-bbf0-4fab-a98e-468181ee51de",
                     UserId = "e9b43ab8-ad6b-4a8e-949c-a4d14312c1ca"
                 },

                  new IdentityUserRole<string>
                  {
                      RoleId = "c6a02c66-bbf0-4fab-a98e-468181ee51de",
                      UserId = "63cb8c98-1927-46b6-aa72-d2e7bc12cf49"
                  },

                 new IdentityUserRole<string>
                 {
                     RoleId = "b6a02c66-acf0-4fab-a98e-467080ee51df",
                     UserId = "d6a02c66-abf0-4fab-a98e-468080ee51df"
                 }

                );

        }
    }
}