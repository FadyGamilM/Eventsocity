using Eventsocity.Domain.Entities;
using Eventsocity.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eventsocity.Infrastructure.Configurations;

public class UserConfig
{
   public static async Task SeedUsers(DataContext context, UserManager<User> userManager)
   {
      if(!userManager.Users.Any())
      {
         var users = new List<User>{
            new User{DisplayName="Fady Gamil", Email="fady@mail.com", UserName="Fady"},
            new User{DisplayName="Magy Magdy", Email="magy@mail.com", UserName="Magy"},
            new User{DisplayName="Amir Ashraf", Email="amir@mail.com", UserName="Amir"},
         };

         foreach (var user in users)
         {
            await userManager.CreateAsync(user, "passw0rd");            
         }
      }
   }
}