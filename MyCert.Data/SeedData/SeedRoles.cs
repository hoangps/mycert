using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MyCert.Data.SeedData
{
    public class SeedRoles
    {
        private static readonly string[] Roles = { "SysAdmin", "Administrator", "Employer", "User" };

        public static IdentityRole[] GetRoles()
        {
            return Roles.Select(roleName => new IdentityRole
            {
                Name = roleName
            }).ToArray();
        }
    }
}
