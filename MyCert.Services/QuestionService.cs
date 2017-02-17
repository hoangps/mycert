using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using MyCert.Data.Models;
using MyCert.Repository;
using MyCert.Services.DTO;

namespace MyCert.Services
{
    public class QuestionService : IService<QuestionDTO>
    {
        private readonly QuestionRepository _questionRepository;
        private readonly AnswerRepository _answerRepository;
        private readonly UserManager<ApplicationUser> _userManager;

        public QuestionService(QuestionRepository questionRepository,
            UserManager<ApplicationUser> userManager,
            AnswerRepository answerRepository)
        {
            _questionRepository = questionRepository;
            _answerRepository = answerRepository;
            _userManager = userManager;
        }

        public IEnumerable<QuestionDTO> GetAll(Func<QuestionDTO, bool> predicate = null)
        {
            return _questionRepository.GetAll().Select(QuestionDTO.ToDTO);
        }

        public QuestionDTO Get(Func<QuestionDTO, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public void Create(QuestionDTO entityDTO)
        {
            throw new NotImplementedException();
        }

        public void Update(QuestionDTO entityDTO)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
