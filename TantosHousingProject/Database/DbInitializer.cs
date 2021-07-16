﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TantosHousingProject.Database
{
    public class DbInitializer
    {
        public static void Initialize(
            THPDbContext context,
            RoleManager<IdentityRole> roleManager,
            UserManager<IdentityUser> userManager)
        {
            //context.Database.EnsureCreated();
            //If not using EF migrations
            context.Database.Migrate();

            if (context.Roles.Any())
            {
                return;
            }

            //------------ Seed into database -------------------

            string[] rolesToSeed = new string[] { "Admin", "User" };

            foreach (var roleName in rolesToSeed)
            {
                IdentityRole role = new IdentityRole(roleName);

                var result = roleManager.CreateAsync(role).Result;

                if (!result.Succeeded)
                {
                    throw new Exception("Failed to create Role" + roleName);
                }
            }

            IdentityUser user = new IdentityUser()
            {
                UserName = "AdminPower",
                Email = "a@a.a",
                PhoneNumber = "123123"
            };

            IdentityResult resultUser = userManager.CreateAsync(user, "Qwert!2345").Result;

            if (!resultUser.Succeeded)
            {
                throw new Exception("Failed to create Admin Acc: AdminPower");

            }

            IdentityResult resultAssign = userManager.AddToRoleAsync(user, rolesToSeed[0]).Result;

            if (!resultAssign.Succeeded)
            {
                throw new Exception($"Failed to grant {rolesToSeed[0]} role to AdminPower");

            }
        }
    }
}
