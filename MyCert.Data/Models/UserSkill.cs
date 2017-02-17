using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCert.Data.Models
{
    public class UserSkill : BaseEntity
    {
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        public Guid SkillId { get; set; }
        public Skill Skill { get; set; }

        public bool IsCertified { get; set; }
    }
}
