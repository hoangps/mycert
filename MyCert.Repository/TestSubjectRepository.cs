using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCert.Data.Models;

namespace MyCert.Repository
{
    public class TestSubjectRepository : IRepository<TestSubject>
    {
        public IEnumerable<TestSubject> GetAll(Func<TestSubject, bool> predicate = null)
        {
            throw new NotImplementedException();
        }

        public TestSubject Get(Func<TestSubject, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public void Add(TestSubject entity)
        {
            throw new NotImplementedException();
        }

        public void Attach(TestSubject entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TestSubject entity)
        {
            throw new NotImplementedException();
        }
    }
}
