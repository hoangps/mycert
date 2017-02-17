using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCert.Data.Models
{
    public class Answer : BaseEntity
    {
        [Required]
        public string Text { get; set; }

        public bool PreferedLast { get; set; }

        public bool IsCorrectAnswer { get; set; }


        public Guid QuestionId { get; set; }
        public Question Question { get; set; }
    }
}
