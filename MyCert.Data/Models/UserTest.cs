using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCert.Data.Models
{
    public class UserTest : BaseEntity
    {
        public DateTime StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public double Score { get; set; }

        public bool IsFinished { get; set; }

        public bool IsPassed { get; set; }

        public bool IsPrivate { get; set; }


        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public Guid TestId { get; set; }

        public Test Test { get; set; }
    }
}
