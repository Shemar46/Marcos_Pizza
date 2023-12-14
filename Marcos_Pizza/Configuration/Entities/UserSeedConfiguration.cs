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
                     Id = "e9b43ab8-ad6b-4a8e-949c-a4d14312c1ca",
                     Email = "admin1@yah.com",
                     NormalizedEmail = "ADMIN1@YAH.COM",
                     NormalizedUserName = "ADMIN1@YAH.COM",
                     UserName = "admin1@yah.com",
                     FirstName = "user",
                     LastName = "Admin",
                     PasswordHash = hasher.HashPassword(null, "Password1"),
                     EmailConfirmed = true
                 },
                  new User
                  {
                      Id = "43cb8c89-9172-46b6-aa72-f2e7bc12cf49",
                      Email ="admin1@yahoo.com",
                      NormalizedEmail ="ADMIN1@YAHOO.COM",
                      NormalizedUserName ="ADMIN1@YAHOO.COM",
                      UserName ="admin1@yahoo.com",
                      FirstName = "user",
                      LastName = "Admin",
                      PasswordHash = hasher.HashPassword(null,"P@ssword1"),
                      EmailConfirmed= true
                  },


                   new User
                   {
                       Id = "63cb8c98-1927-46b6-aa72-d2e7bc12cf49",
                       Email = "admin1@hoo.com",
                       NormalizedEmail = "ADMIN1@HOO.COM",
                       NormalizedUserName = "ADMIN1@HOO.COM",
                       UserName = "admin1@hoo.com",
                       FirstName = "user",
                       LastName = "Admin",
                       PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                       EmailConfirmed = true
                   },

                  new User
                  {
                      Id = "d6a02c66-abf0-4fab-a98e-468080ee51df",
                      Email = "mar@user.com",
                      NormalizedEmail = "MAR@USER.COM",
                      NormalizedUserName = "MAR@USER.COM",
                      UserName = "mar@user.com",

                      FirstName = "Mar",
                      LastName = "user",
                      PasswordHash = hasher.HashPassword(null,"P@ssword1"),
                      EmailConfirmed = true

                  }

                  


                  //be70bfbe-3812-4a37-b42d-66d9ed5baf5f
                ); ;
        }
    }
}