using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MyCert.Data.Models;
using MyCert.Data.SeedData;

namespace MyCert.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MyCert.Data.ApplicationDbContext>
    {
        private static readonly string[] Roles = { "SysAdmin", "Administrator", "Tester", "ContentEditor", "Employer", "User" };

        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MyCert.Data.ApplicationDbContext context)
        {
            var roleStore = new RoleStore<IdentityRole>(context);
            var roleManager = new RoleManager<IdentityRole>(roleStore);

            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(userStore);

            foreach (var role in from roleName in Roles
                                    where !context.Roles.Any(r => r.Name == roleName)
                                    select new IdentityRole { Name = roleName })
            {
                roleManager.Create(role);
            }

            
            if (!context.Users.Any(u => u.UserName == "homer"))
            {
                var user = new ApplicationUser
                {
                    UserName = "dajkavn@gmail.com",
                    FirstName = "Homer",
                    LastName = "Phan",
                    Email = "dajkavn@gmail.com",
                    EmailConfirmed = true
                };

                userManager.Create(user, "123qwe!@#QWE");
                userManager.AddToRole(user.Id, "SysAdmin");
            }

            if (!context.Users.Any(u => u.UserName == "admin"))
            {
                var user = new ApplicationUser
                {
                    UserName = "dajkavn+1@gmail.com",
                    FirstName = "Administrator",
                    LastName = "",
                    Email = "dajkavn+1@gmail.com",
                    EmailConfirmed = true
                };

                userManager.Create(user, "123qwe!@#QWE");
                userManager.AddToRole(user.Id, "Administrator");
            }

            if (!context.Users.Any(u => u.UserName == "tester"))
            {
                var user = new ApplicationUser
                {
                    UserName = "dajkavn+2@gmail.com",
                    FirstName = "Tester",
                    LastName = "",
                    Email = "dajkavn+2@gmail.com",
                    EmailConfirmed = true
                };

                userManager.Create(user, "123qwe!@#QWE");
                userManager.AddToRole(user.Id, "Tester");
            }
        }
    }
}
