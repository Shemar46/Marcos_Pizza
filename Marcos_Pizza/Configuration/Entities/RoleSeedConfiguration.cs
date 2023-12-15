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
                  Id = "43cb8c89-9172-46b6-aa72-e2e7dc12cf49",
                  Name = "Administrator",
                  NormalizedName = "ADMINISTRATOR"
              },


                 new IdentityRole
                 {
                     Id = "c6a02c66-bbf0-4fab-a98e-468181ee51de",
                     Name = "System",
                     NormalizedName = "SYSTEM"
                 },

              new IdentityRole
              {
                  Id = "f4e166e1-363f-4f5e-a91d-b4b957c27cdc",
                  Name = "SuperAdmin",
                  NormalizedName = "SUPERADMIN"
              },




              new IdentityRole
              {
                  Id = "b6a02c66-acf0-4fab-a98e-467080ee51df",
                  Name = "User",
                  NormalizedName = "USER"
              }

              );
        }
    }
}