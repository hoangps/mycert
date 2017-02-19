namespace MyCert.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Answers",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true, defaultValueSql: "newsequentialid()"),
                        Text = c.String(nullable: false),
                        PreferedLast = c.Boolean(nullable: false),
                        IsCorrectAnswer = c.Boolean(nullable: false),
                        QuestionId = c.Guid(nullable: false),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7, defaultValueSql: "getutcdate()"),
                        CreatedBy = c.String(maxLength: 38),
                        UpdatedAt = c.DateTimeOffset(nullable: false, precision: 7, defaultValueSql: "getutcdate()"),
                        UpdatedBy = c.String(maxLength: 38),
                        Version = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Questions", t => t.QuestionId, cascadeDelete: true)
                .Index(t => t.QuestionId);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true, defaultValueSql: "newsequentialid()"),
                        Text = c.String(nullable: false),
                        SubText = c.String(),
                        QuestionType = c.Int(nullable: false),
                        Score = c.Double(nullable: false),
                        QuestionCategoryId = c.Guid(),
                        SubjectId = c.Guid(nullable: false),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7, defaultValueSql: "getutcdate()"),
                        CreatedBy = c.String(maxLength: 38),
                        UpdatedAt = c.DateTimeOffset(nullable: false, precision: 7, defaultValueSql: "getutcdate()"),
                        UpdatedBy = c.String(maxLength: 38),
                        Version = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.QuestionCategories", t => t.QuestionCategoryId)
                .ForeignKey("dbo.Subjects", t => t.SubjectId, cascadeDelete: true)
                .Index(t => t.QuestionCategoryId)
                .Index(t => t.SubjectId);
            
            CreateTable(
                "dbo.QuestionCategories",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true, defaultValueSql: "newsequentialid()"),
                        Name = c.String(),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7, defaultValueSql: "getutcdate()"),
                        CreatedBy = c.String(maxLength: 38),
                        UpdatedAt = c.DateTimeOffset(nullable: false, precision: 7, defaultValueSql: "getutcdate()"),
                        UpdatedBy = c.String(maxLength: 38),
                        Version = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true, defaultValueSql: "newsequentialid()"),
                        Name = c.String(nullable: false),
                        Introduction = c.String(),
                        SubjectCategoryId = c.Guid(),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7, defaultValueSql: "getutcdate()"),
                        CreatedBy = c.String(maxLength: 38),
                        UpdatedAt = c.DateTimeOffset(nullable: false, precision: 7, defaultValueSql: "getutcdate()"),
                        UpdatedBy = c.String(maxLength: 38),
                        Version = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SubjectCategories", t => t.SubjectCategoryId)
                .Index(t => t.SubjectCategoryId);
            
            CreateTable(
                "dbo.Certificates",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true, defaultValueSql: "newsequentialid()"),
                        Name = c.String(),
                        OrganizationOfCertification = c.String(),
                        Template = c.String(),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7, defaultValueSql: "getutcdate()"),
                        CreatedBy = c.String(maxLength: 38),
                        UpdatedAt = c.DateTimeOffset(nullable: false, precision: 7, defaultValueSql: "getutcdate()"),
                        UpdatedBy = c.String(maxLength: 38),
                        Version = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        Subject_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Subjects", t => t.Subject_Id)
                .Index(t => t.Subject_Id);
            
            CreateTable(
                "dbo.Tests",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true, defaultValueSql: "newsequentialid()"),
                        Name = c.String(nullable: false),
                        Introduction = c.String(nullable: false),
                        Duration = c.Int(nullable: false),
                        PassScore = c.Double(nullable: false),
                        IsPrivate = c.Boolean(nullable: false),
                        IsEnabled = c.Boolean(nullable: false),
                        CertificateId = c.Guid(),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7, defaultValueSql: "getutcdate()"),
                        CreatedBy = c.String(maxLength: 38),
                        UpdatedAt = c.DateTimeOffset(nullable: false, precision: 7, defaultValueSql: "getutcdate()"),
                        UpdatedBy = c.String(maxLength: 38),
                        Version = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Certificates", t => t.CertificateId)
                .Index(t => t.CertificateId);
            
            CreateTable(
                "dbo.TestSubjects",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true, defaultValueSql: "newsequentialid()"),
                        QuestionQuota = c.Int(nullable: false),
                        TestId = c.Guid(nullable: false),
                        SubjectId = c.Guid(nullable: false),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7, defaultValueSql: "getutcdate()"),
                        CreatedBy = c.String(maxLength: 38),
                        UpdatedAt = c.DateTimeOffset(nullable: false, precision: 7, defaultValueSql: "getutcdate()"),
                        UpdatedBy = c.String(maxLength: 38),
                        Version = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Subjects", t => t.SubjectId, cascadeDelete: true)
                .ForeignKey("dbo.Tests", t => t.TestId, cascadeDelete: true)
                .Index(t => t.TestId)
                .Index(t => t.SubjectId);
            
            CreateTable(
                "dbo.SubjectCategories",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true, defaultValueSql: "newsequentialid()"),
                        Name = c.String(nullable: false),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7, defaultValueSql: "getutcdate()"),
                        CreatedBy = c.String(maxLength: 38),
                        UpdatedAt = c.DateTimeOffset(nullable: false, precision: 7, defaultValueSql: "getutcdate()"),
                        UpdatedBy = c.String(maxLength: 38),
                        Version = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true, defaultValueSql: "newsequentialid()"),
                        Name = c.String(),
                        SubjectId = c.Guid(),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7, defaultValueSql: "getutcdate()"),
                        CreatedBy = c.String(maxLength: 38),
                        UpdatedAt = c.DateTimeOffset(nullable: false, precision: 7, defaultValueSql: "getutcdate()"),
                        UpdatedBy = c.String(maxLength: 38),
                        Version = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Subjects", t => t.SubjectId)
                .Index(t => t.SubjectId);
            
            CreateTable(
                "dbo.UserCertificates",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true, defaultValueSql: "newsequentialid()"),
                        UserScore = c.Double(nullable: false),
                        MaxScore = c.Double(nullable: false),
                        DateOfCertification = c.DateTime(nullable: false),
                        UserId = c.String(maxLength: 128),
                        CertificateId = c.Guid(nullable: false),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7, defaultValueSql: "getutcdate()"),
                        CreatedBy = c.String(maxLength: 38),
                        UpdatedAt = c.DateTimeOffset(nullable: false, precision: 7, defaultValueSql: "getutcdate()"),
                        UpdatedBy = c.String(maxLength: 38),
                        Version = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Certificates", t => t.CertificateId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.CertificateId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        FullName = c.String(),
                        DateOfBirth = c.DateTime(),
                        Address = c.String(),
                        SocialIdentificationNumber = c.String(),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7, defaultValueSql: "getutcdate()"),
                        UpdatedAt = c.DateTimeOffset(precision: 7, defaultValueSql: "getutcdate()"),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.UserReferences",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true, defaultValueSql: "newsequentialid()"),
                        Name = c.String(nullable: false),
                        Position = c.String(nullable: false),
                        Location = c.String(nullable: false),
                        EmailAddress = c.String(nullable: false),
                        PhoneNumber = c.String(),
                        Note = c.String(),
                        UserId = c.String(maxLength: 128),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7, defaultValueSql: "getutcdate()"),
                        CreatedBy = c.String(maxLength: 38),
                        UpdatedAt = c.DateTimeOffset(nullable: false, precision: 7, defaultValueSql: "getutcdate()"),
                        UpdatedBy = c.String(maxLength: 38),
                        Version = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.UserTests",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true, defaultValueSql: "newsequentialid()"),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(),
                        Score = c.Double(nullable: false),
                        IsFinished = c.Boolean(nullable: false),
                        IsPassed = c.Boolean(nullable: false),
                        IsPrivate = c.Boolean(nullable: false),
                        UserId = c.String(maxLength: 128),
                        TestId = c.Guid(nullable: false),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7, defaultValueSql: "getutcdate()"),
                        CreatedBy = c.String(maxLength: 38),
                        UpdatedAt = c.DateTimeOffset(nullable: false, precision: 7, defaultValueSql: "getutcdate()"),
                        UpdatedBy = c.String(maxLength: 38),
                        Version = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tests", t => t.TestId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.TestId);
            
            CreateTable(
                "dbo.UserPartitionInfoes",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true, defaultValueSql: "newsequentialid()"),
                        Name = c.String(nullable: false),
                        Location = c.String(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Description = c.String(),
                        Type = c.Int(nullable: false),
                        UserId = c.String(maxLength: 128),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7, defaultValueSql: "getutcdate()"),
                        CreatedBy = c.String(maxLength: 38),
                        UpdatedAt = c.DateTimeOffset(nullable: false, precision: 7, defaultValueSql: "getutcdate()"),
                        UpdatedBy = c.String(maxLength: 38),
                        Version = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.UserSkills",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true, defaultValueSql: "newsequentialid()"),
                        UserId = c.String(maxLength: 128),
                        SkillId = c.Guid(nullable: false),
                        IsCertified = c.Boolean(nullable: false),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7, defaultValueSql: "getutcdate()"),
                        CreatedBy = c.String(maxLength: 38),
                        UpdatedAt = c.DateTimeOffset(nullable: false, precision: 7, defaultValueSql: "getutcdate()"),
                        UpdatedBy = c.String(maxLength: 38),
                        Version = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Skills", t => t.SkillId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.SkillId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserSkills", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.UserSkills", "SkillId", "dbo.Skills");
            DropForeignKey("dbo.UserPartitionInfoes", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.UserCertificates", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.UserTests", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.UserTests", "TestId", "dbo.Tests");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.UserReferences", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.UserCertificates", "CertificateId", "dbo.Certificates");
            DropForeignKey("dbo.Skills", "SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Subjects", "SubjectCategoryId", "dbo.SubjectCategories");
            DropForeignKey("dbo.Questions", "SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.Certificates", "Subject_Id", "dbo.Subjects");
            DropForeignKey("dbo.TestSubjects", "TestId", "dbo.Tests");
            DropForeignKey("dbo.TestSubjects", "SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.Tests", "CertificateId", "dbo.Certificates");
            DropForeignKey("dbo.Questions", "QuestionCategoryId", "dbo.QuestionCategories");
            DropForeignKey("dbo.Answers", "QuestionId", "dbo.Questions");
            DropIndex("dbo.UserSkills", new[] { "SkillId" });
            DropIndex("dbo.UserSkills", new[] { "UserId" });
            DropIndex("dbo.UserPartitionInfoes", new[] { "UserId" });
            DropIndex("dbo.UserTests", new[] { "TestId" });
            DropIndex("dbo.UserTests", new[] { "UserId" });
            DropIndex("dbo.UserReferences", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.UserCertificates", new[] { "CertificateId" });
            DropIndex("dbo.UserCertificates", new[] { "UserId" });
            DropIndex("dbo.Skills", new[] { "SubjectId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.TestSubjects", new[] { "SubjectId" });
            DropIndex("dbo.TestSubjects", new[] { "TestId" });
            DropIndex("dbo.Tests", new[] { "CertificateId" });
            DropIndex("dbo.Certificates", new[] { "Subject_Id" });
            DropIndex("dbo.Subjects", new[] { "SubjectCategoryId" });
            DropIndex("dbo.Questions", new[] { "SubjectId" });
            DropIndex("dbo.Questions", new[] { "QuestionCategoryId" });
            DropIndex("dbo.Answers", new[] { "QuestionId" });
            DropTable("dbo.UserSkills");
            DropTable("dbo.UserPartitionInfoes");
            DropTable("dbo.UserTests");
            DropTable("dbo.UserReferences");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.UserCertificates");
            DropTable("dbo.Skills");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.SubjectCategories");
            DropTable("dbo.TestSubjects");
            DropTable("dbo.Tests");
            DropTable("dbo.Certificates");
            DropTable("dbo.Subjects");
            DropTable("dbo.QuestionCategories");
            DropTable("dbo.Questions");
            DropTable("dbo.Answers");
        }
    }
}
