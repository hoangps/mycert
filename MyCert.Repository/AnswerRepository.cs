using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCert.Data.Models;

namespace MyCert.Repository
{
    public class AnswerRepository : IRepository<Answer>
    {
        public IEnumerable<Answer> GetAll(Func<Answer, bool> predicate = null)
        {
            throw new NotImplementedException();
        }

        public Answer Get(Func<Answer, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public void Add(Answer entity)
        {
            throw new NotImplementedException();
        }

        public void Attach(Answer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Answer entity)
        {
            throw new NotImplementedException();
        }
    }
}
