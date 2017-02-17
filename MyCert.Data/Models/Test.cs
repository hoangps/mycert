using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCert.Data.Models
{
    public class Test : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Introduction { get; set; }

        [Required]
        public int Duration { get; set; }

        [Required]
        public double PassScore { get; set; } 

        public bool IsPrivate { get; set; }

        public bool IsEnabled { get; set; }


        public Guid? CertificateId { get; set; }
        public Certificate Certificate { get; set; }

        public List<TestSubject> TestSubjects { get; set; }
    }
}
