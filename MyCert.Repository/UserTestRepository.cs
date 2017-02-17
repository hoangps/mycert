using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCert.Data.Models;

namespace MyCert.Repository
{
    public class UserTestRepository : IRepository<UserTest>
    {
        public IEnumerable<UserTest> GetAll(Func<UserTest, bool> predicate = null)
        {
            throw new NotImplementedException();
        }

        public UserTest Get(Func<UserTest, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public void Add(UserTest entity)
        {
            throw new NotImplementedException();
        }

        public void Attach(UserTest entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(UserTest entity)
        {
            throw new NotImplementedException();
        }
    }
}
