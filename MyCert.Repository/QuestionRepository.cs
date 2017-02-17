using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCert.Data;
using MyCert.Data.Models;

namespace MyCert.Repository
{
    public class QuestionRepository : IRepository<Question>
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        public IEnumerable<Question> GetAll(Func<Question, bool> predicate = null)
        {
            if (predicate != null)
            {
                return _context.Questions.Where(predicate);
            }

            return _context.Questions;
        }

        public Question Get(Func<Question, bool> predicate)
        {
            return _context.Questions.FirstOrDefault(predicate);
        }

        public void Add(Question entity)
        {
            _context.Questions.Add(entity);
        }

        public void Attach(Question entity)
        {
            _context.Questions.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(Question entity)
        {
            _context.Questions.Remove(entity);
        }

        internal void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
