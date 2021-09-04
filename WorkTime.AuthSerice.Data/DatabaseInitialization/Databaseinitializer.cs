using System;
using System.Security.Claims;
using System.Threading.Tasks;
using IdentityModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace WorkTime.AuthSerice.Data.DatabaseInitialization
{
    public static class DatabaseInitializer
    {
        public static async Task InitAsync(IServiceProvider scopeServiceProvider)
        {
            var userManager = scopeServiceProvider.GetService<UserManager<IdentityUser>>();
            var roleManager = scopeServiceProvider.GetService<RoleManager<IdentityRole>>();

            //var result = userManager.CreateAsync(user, "123qwe").GetAwaiter().GetResult();
            //if (result.Succeeded)
            //{
            //    userManager.AddClaimAsync(user, new Claim(ClaimTypes.Role, "Administrator")).GetAwaiter().GetResult();
            //    userManager.AddClaimAsync(user, new Claim(JwtClaimTypes.Scope, "OrdersAPI")).GetAwaiter().GetResult();
            //    userManager.AddClaimAsync(user, new Claim(JwtClaimTypes.Scope, "SwaggerAPI")).GetAwaiter().GetResult();
            //}

            string adminName = "admin";
            if (await roleManager.FindByNameAsync("Administrator") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("Administrator"));
            }
            if (await roleManager.FindByNameAsync("Employee") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("Employee"));
            }
            if (await userManager.FindByNameAsync(adminName) == null)
            {
                var admin = new IdentityUser
                {
                    UserName = adminName
                };
                IdentityResult result = await userManager.CreateAsync(admin, "123qwe");
                if (result.Succeeded)
                {


                    await userManager.AddToRoleAsync(admin, "Administrator");
                    userManager.AddClaimAsync(admin, new Claim(JwtClaimTypes.Scope, "SwaggerAPI")).GetAwaiter().GetResult();
                    userManager.AddClaimAsync(admin, new Claim(ClaimTypes.Role, "Administrator1")).GetAwaiter().GetResult();
                    userManager.AddClaimAsync(admin, new Claim(JwtClaimTypes.Scope, "OrdersAPI")).GetAwaiter().GetResult();

                }
            }
        }
    }
}