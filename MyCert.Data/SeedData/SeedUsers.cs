using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCert.Data.Models;

namespace MyCert.Data.SeedData
{
    public class SeedUsers
    {
        public static ApplicationUser[] GetUsers()
        {
            var users = new List<ApplicationUser>
            {
                new ApplicationUser
                {
                    UserName = "homer",
                    FirstName = "Homer",
                    LastName = "Phan",
                    Email = "dajkavn@gmail.com",
                    EmailConfirmed = true
                },
                new ApplicationUser
                {
                    UserName = "admin",
                    FirstName = "Administrator",
                    LastName = "",
                    Email = "dajkavn+1@gmail.com",
                    EmailConfirmed = true
                },
                new ApplicationUser
                {
                    UserName = "tester",
                    FirstName = "Tester",
                    LastName = "",
                    Email = "dajkavn+2@gmail.com",
                    EmailConfirmed = true
                }
            };

            return users.ToArray();
        }
    }
}
