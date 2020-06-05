using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YSKProje.ToDo.Entities.Concrete;

namespace YSKProje.ToDo.Web
{
    public static class IdentityInitializer
    {

        public static async Task SeedData(UserManager<AppUser> userManager,RoleManager<AppRole> roleManager)
        {
            var adminRole = await roleManager.FindByNameAsync("Admin");
            if (adminRole == null)
            {
                await roleManager.CreateAsync(new AppRole { Name="Admin" });
            }
            var memberRole = await roleManager.FindByNameAsync("Member");
            if (memberRole == null)
            {
                await roleManager.CreateAsync(new AppRole { Name = "Member" });
            }

            var adminUser = await userManager.FindByNameAsync("yavuz");
            if (adminUser == null)
            {
                AppUser appUser = new AppUser
                {
                    Name = "Yavuz",
                    Surname = "Kahraman",
                    UserName = "yavuz",
                    Email = "yavuz@gmail.com",
                };
                await userManager.CreateAsync(appUser, "1");
                await userManager.AddToRoleAsync(appUser, "Admin");
            }
        }
    }
}
