using Marcos_Pizza.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Xml.Linq;

namespace Marcos_Pizza.Web.Configuration.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<User>
    {
       public void Configure(EntityTypeBuilder<User> builder)
        {
            var hasher =new PasswordHasher<User>();
            builder.HasData(
                  new User
                  {
                      Id ="e9b43ab8-ab3d-4a8f-949c-a4d14312d1ca",
                      Email ="admin1@yahoo.com",
                      NormalizedEmail ="ADMIN1@YAHOO.COM",
                      UserName ="admin1@yahoo.com",
                      FirstName = "user",
                      LastName = "Admin",
                      PasswordHash = hasher.HashPassword(null,"Password1"),
                      EmailConfirmed= true
                  },


                  new User
                  {
                      Id = "be70bfbe-3812-5a37-b42d-66d9ed5baf7e",
                      Email = "mar@user.com",
                      NormalizedEmail = "MAR@USER.COM",
                      UserName = "mar@user.com",
                      FirstName = "Mar",
                      LastName = "user",
                      PasswordHash = hasher.HashPassword(null,"Password12"),
                      EmailConfirmed = true

                  },

                   new User
                   {
                       Id ="e9b43ab8-ad6b-4a8e-949c-a4d14312c1ca",
                       Email ="admin123@yahoo.com",
                       NormalizedEmail ="ADMIN123@YAHOO.COM",
                       UserName ="admin123@yahoo.com",
                       FirstName ="user123",
                       LastName = "Admin123",
                       PasswordHash = hasher.HashPassword(null, "Admin123"),
                       EmailConfirmed = true
                   }



                  //be70bfbe-3812-4a37-b42d-66d9ed5baf5f
                ); ;
        }
    }
}