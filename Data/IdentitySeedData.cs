using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using ResolutionSigningSystem.Data;

namespace ResolutionSigningSystem.Data
{
    public class IdentitySeedData
    {
        public static async Task Initialize(ApplicationDbContext context,
        UserManager<IdentityUser> userManager,
        RoleManager<IdentityRole> roleManager)
        {

            context.Database.EnsureCreated();
            string adminRole = "Admin";
            string memberRole1 = "Board member 1";
            string memberRole2 = "Board member 2";
            string memberRole3 = "Board member 3";
            string memberRole4 = "Board member 4";
            string memberRole5 = "Board member 5";
            string password4all = "P@$$w0rd";

            if (await roleManager.FindByNameAsync(adminRole) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(adminRole));
            }

            if (await roleManager.FindByNameAsync(memberRole1) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(memberRole1));
            }

            if (await roleManager.FindByNameAsync(memberRole2) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(memberRole2));
            }


            if (await roleManager.FindByNameAsync(memberRole3) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(memberRole3));
            }


            if (await roleManager.FindByNameAsync(memberRole4) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(memberRole4));
            }


            if (await roleManager.FindByNameAsync(memberRole5) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(memberRole5));
            }


            if (await userManager.FindByNameAsync("a@a.a") == null)
            {
                var user = new IdentityUser
                {
                    UserName = "a@a.a",
                    Email = "a@a.a"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password4all);
                    await userManager.AddToRoleAsync(user, adminRole);
                }
            }

            if (await userManager.FindByNameAsync("1@1.1") == null)
            {
                var user = new IdentityUser
                {
                    UserName = "1@1.1",
                    Email = "1@1.1"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password4all);
                    await userManager.AddToRoleAsync(user, memberRole1);
                }
            }

            if (await userManager.FindByNameAsync("2@2.2") == null)
            {
                var user = new IdentityUser
                {
                    UserName = "2@2.2",
                    Email = "2@2.2"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password4all);
                    await userManager.AddToRoleAsync(user, memberRole2);
                }
            }

            if (await userManager.FindByNameAsync("3@3.3") == null)
            {
                var user = new IdentityUser
                {
                    UserName = "3@3.3",
                    Email = "3@3.3"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password4all);
                    await userManager.AddToRoleAsync(user, memberRole3);
                }
            }

            if (await userManager.FindByNameAsync("4@4.4") == null)
            {
                var user = new IdentityUser
                {
                    UserName = "4@4.4",
                    Email = "4@4.4"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password4all);
                    await userManager.AddToRoleAsync(user, memberRole4);
                }
            }

            if (await userManager.FindByNameAsync("5@5.5") == null)
            {
                var user = new IdentityUser
                {
                    UserName = "5@5.5",
                    Email = "5@5.5"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password4all);
                    await userManager.AddToRoleAsync(user, memberRole5);
                }
            }
        }
    }
}