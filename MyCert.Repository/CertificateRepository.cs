using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCert.Data.Models;

namespace MyCert.Repository
{
    public class CertificateRepository : IRepository<Certificate>
    {
        public IEnumerable<Certificate> GetAll(Func<Certificate, bool> predicate = null)
        {
            throw new NotImplementedException();
        }

        public Certificate Get(Func<Certificate, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public void Add(Certificate entity)
        {
            throw new NotImplementedException();
        }

        public void Attach(Certificate entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Certificate entity)
        {
            throw new NotImplementedException();
        }
    }
}
