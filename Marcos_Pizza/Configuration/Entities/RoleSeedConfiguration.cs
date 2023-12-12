using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Marcos_Pizza.Web.Configuration.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        void IEntityTypeConfiguration<IdentityRole>.Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
              new IdentityRole
              {
                  Id = "e8b43kb8-ad6b-4a8e-949c-a5d14312c1ca",
                  Name = "Administrator",
                  NormalizedName = "ADMINISTRATOR"
              },




              new IdentityRole
              {
                  Id = "be70bfb6-3812-4b96-b42d-66d7ed5baf5f",
                  Name = "User",
                  NormalizedName = "USER"
              }

              );
        }
    }
}