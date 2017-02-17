using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using MyCert.Data.Models;

namespace MyCert.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public DbSet<Answer> Answers { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionCategory> QuestionCategories { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<SubjectCategory> SubjectCategories { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<TestSubject> TestSubjects { get; set; }
        public DbSet<UserCertificate> UserCertificates { get; set; }
        public DbSet<UserPartitionInfo> UserPartitionInfos { get; set; }
        public DbSet<UserReference> UserReferences { get; set; }
        public DbSet<UserSkill> UserSkills { get; set; }
        public DbSet<UserTest> UserTests { get; set; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
//            builder.Entity<ApplicationUser>().HasOne(p => p.Tenant).WithMany(p => p.Users).HasForeignKey(p => p.TenantId).OnDelete(DeleteBehavior.SetNull);

            base.OnModelCreating(builder);
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
