namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class b1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Answers",
                c => new
                    {
                        AnswerId = c.Int(nullable: false, identity: true),
                        answer = c.String(),
                        questionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AnswerId)
                .ForeignKey("dbo.Questions", t => t.questionId, cascadeDelete: true)
                .Index(t => t.questionId);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        questionId = c.Int(nullable: false, identity: true),
                        question = c.String(),
                        id_correct_answer = c.Int(nullable: false),
                        category = c.String(),
                        applicant_Id = c.Int(),
                    })
                .PrimaryKey(t => t.questionId)
                .ForeignKey("dbo.Applicant", t => t.applicant_Id)
                .Index(t => t.applicant_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LastName = c.String(),
                        FirstName = c.String(),
                        Password = c.String(nullable: false),
                        Email = c.String(),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ApplicantAnswers",
                c => new
                    {
                        app_answerId = c.Int(nullable: false, identity: true),
                        applicantId = c.Int(nullable: false),
                        questionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.app_answerId)
                .ForeignKey("dbo.Applicant", t => t.applicantId)
                .ForeignKey("dbo.Questions", t => t.questionId, cascadeDelete: true)
                .Index(t => t.applicantId)
                .Index(t => t.questionId);
            
            CreateTable(
                "dbo.ApplicantRequests",
                c => new
                    {
                        ApplicantRequestId = c.Int(nullable: false),
                        app_req_date = c.DateTime(nullable: false),
                        specialty = c.String(),
                        app_req_state = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ApplicantRequestId)
                .ForeignKey("dbo.Applicant", t => t.ApplicantRequestId)
                .Index(t => t.ApplicantRequestId);
            
            CreateTable(
                "dbo.ApplicantRessources",
                c => new
                    {
                        AppResId = c.Int(nullable: false, identity: true),
                        ressourceId = c.Int(),
                        applicantId = c.Int(),
                    })
                .PrimaryKey(t => t.AppResId)
                .ForeignKey("dbo.Applicant", t => t.applicantId)
                .ForeignKey("dbo.Ressource", t => t.ressourceId)
                .Index(t => t.ressourceId)
                .Index(t => t.applicantId);
            
            CreateTable(
                "dbo.CustomUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                        Users_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .Index(t => t.Users_Id);
            
            CreateTable(
                "dbo.Discussions",
                c => new
                    {
                        DiscId = c.Int(nullable: false, identity: true),
                        clientId = c.Int(),
                        ressourceId = c.Int(),
                    })
                .PrimaryKey(t => t.DiscId)
                .ForeignKey("dbo.Client", t => t.clientId)
                .ForeignKey("dbo.Ressource", t => t.ressourceId)
                .Index(t => t.clientId)
                .Index(t => t.ressourceId);
            
            CreateTable(
                "dbo.CustomUserLogins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LoginProvider = c.String(),
                        ProviderKey = c.String(),
                        UserId = c.Int(nullable: false),
                        Users_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .Index(t => t.Users_Id);
            
            CreateTable(
                "dbo.OrganizationCharts",
                c => new
                    {
                        directional_level = c.String(nullable: false, maxLength: 128),
                        program_name = c.String(),
                        project_responsable = c.String(),
                        client_name = c.String(),
                        account_manager = c.String(),
                        name_assignement_manager_client = c.String(),
                        Client_Id = c.Int(),
                        Project_ProjectId = c.Int(),
                        Ressource_Id = c.Int(),
                    })
                .PrimaryKey(t => t.directional_level)
                .ForeignKey("dbo.Client", t => t.Client_Id)
                .ForeignKey("dbo.Projects", t => t.Project_ProjectId)
                .ForeignKey("dbo.Ressource", t => t.Ressource_Id)
                .Index(t => t.Client_Id)
                .Index(t => t.Project_ProjectId)
                .Index(t => t.Ressource_Id);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ProjectId = c.Int(nullable: false, identity: true),
                        Project_name = c.String(),
                        Start_date = c.DateTime(nullable: false),
                        end_date = c.DateTime(nullable: false),
                        Adress = c.String(),
                        Total_number_ressource = c.Int(nullable: false),
                        Levio_number_ressource = c.Int(nullable: false),
                        project_state = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProjectId);
            
            CreateTable(
                "dbo.Mandates",
                c => new
                    {
                        MandateId = c.Int(nullable: false, identity: true),
                        Start_date = c.DateTime(nullable: false),
                        end_date = c.DateTime(nullable: false),
                        fee = c.Single(nullable: false),
                        nb_task_Todo = c.Int(nullable: false),
                        nb_task_done = c.Int(nullable: false),
                        project_ProjectId = c.Int(),
                        ressource_Id = c.Int(),
                    })
                .PrimaryKey(t => t.MandateId)
                .ForeignKey("dbo.Projects", t => t.project_ProjectId)
                .ForeignKey("dbo.Ressource", t => t.ressource_Id)
                .Index(t => t.project_ProjectId)
                .Index(t => t.ressource_Id);
            
            CreateTable(
                "dbo.ProjectSkills",
                c => new
                    {
                        ProjectSkillId = c.Int(nullable: false, identity: true),
                        Project_ProjectId = c.Int(),
                        Skill_SkillId = c.Int(),
                    })
                .PrimaryKey(t => t.ProjectSkillId)
                .ForeignKey("dbo.Projects", t => t.Project_ProjectId)
                .ForeignKey("dbo.Skills", t => t.Skill_SkillId)
                .Index(t => t.Project_ProjectId)
                .Index(t => t.Skill_SkillId);
            
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        SkillId = c.Int(nullable: false, identity: true),
                        Value = c.String(),
                    })
                .PrimaryKey(t => t.SkillId);
            
            CreateTable(
                "dbo.RessourceSkills",
                c => new
                    {
                        RSId = c.Int(nullable: false, identity: true),
                        Ressource_Id = c.Int(),
                        Skill_SkillId = c.Int(),
                    })
                .PrimaryKey(t => t.RSId)
                .ForeignKey("dbo.Ressource", t => t.Ressource_Id)
                .ForeignKey("dbo.Skills", t => t.Skill_SkillId)
                .Index(t => t.Ressource_Id)
                .Index(t => t.Skill_SkillId);
            
            CreateTable(
                "dbo.Requests",
                c => new
                    {
                        RequestId = c.Int(nullable: false, identity: true),
                        requested_profil = c.String(),
                        experience_year = c.String(),
                        education_scolarity = c.String(),
                        manager = c.String(),
                        deposit_date = c.DateTime(nullable: false),
                        deposit_hour = c.DateTime(nullable: false),
                        Start_date_mandate = c.DateTime(nullable: false),
                        end_date_mandate = c.DateTime(nullable: false),
                        Client_Id = c.Int(),
                    })
                .PrimaryKey(t => t.RequestId)
                .ForeignKey("dbo.Client", t => t.Client_Id)
                .Index(t => t.Client_Id);
            
            CreateTable(
                "dbo.CustomUserRoles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        RoleId = c.Int(nullable: false),
                        CustomRole_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CustomRoles", t => t.CustomRole_Id)
                .Index(t => t.CustomRole_Id);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        MessageId = c.Int(nullable: false, identity: true),
                        SenderId = c.Int(nullable: false),
                        SentDate = c.DateTime(nullable: false),
                        Object = c.String(),
                        Discussion_DiscId = c.Int(),
                    })
                .PrimaryKey(t => t.MessageId)
                .ForeignKey("dbo.Discussions", t => t.Discussion_DiscId)
                .Index(t => t.Discussion_DiscId);
            
            CreateTable(
                "dbo.Leaves",
                c => new
                    {
                        LeaveId = c.Int(nullable: false, identity: true),
                        Start_date = c.DateTime(nullable: false),
                        D_date = c.DateTime(nullable: false),
                        Type_leave = c.Int(nullable: false),
                        Ressource_Id = c.Int(),
                    })
                .PrimaryKey(t => t.LeaveId)
                .ForeignKey("dbo.Ressource", t => t.Ressource_Id)
                .Index(t => t.Ressource_Id);
            
            CreateTable(
                "dbo.Arrivals",
                c => new
                    {
                        ArrivalId = c.Int(nullable: false),
                        ApplicantId = c.Int(nullable: false),
                        DateArrival = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ArrivalId)
                .ForeignKey("dbo.Applicant", t => t.ArrivalId)
                .Index(t => t.ArrivalId);
            
            CreateTable(
                "dbo.RDVs",
                c => new
                    {
                        RdvId = c.Int(nullable: false, identity: true),
                        ApplicantId = c.Int(nullable: false),
                        DateRdv = c.DateTime(nullable: false),
                        StateRdv = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RdvId)
                .ForeignKey("dbo.Applicant", t => t.ApplicantId)
                .Index(t => t.ApplicantId);
            
            CreateTable(
                "dbo.MandateHistories",
                c => new
                    {
                        MandatehistoryId = c.Int(nullable: false, identity: true),
                        saveDate = c.DateTime(nullable: false),
                        MandateId = c.Int(nullable: false),
                        RessourceId = c.Int(nullable: false),
                        ProjectId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MandatehistoryId)
                .ForeignKey("dbo.Mandates", t => t.MandateId, cascadeDelete: true)
                .Index(t => t.MandateId);
            
            CreateTable(
                "dbo.CustomRoles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.CustomUserRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Applicant",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        applicant_state = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Client",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        categorie_c = c.Byte(nullable: false),
                        type_c = c.Int(nullable: false),
                        adresse = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Ressource",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Contrat_type = c.String(),
                        First_name = c.String(),
                        Last_name = c.String(),
                        Seniorty = c.String(),
                        Work_profil = c.String(),
                        Note = c.String(),
                        File = c.String(),
                        Ressource_type = c.Int(nullable: false),
                        Avaibility = c.Int(nullable: false),
                        Salary = c.Single(nullable: false),
                        Sector = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ressource", "Id", "dbo.Users");
            DropForeignKey("dbo.Client", "Id", "dbo.Users");
            DropForeignKey("dbo.Applicant", "Id", "dbo.Users");
            DropForeignKey("dbo.UserRoles", "RoleId", "dbo.CustomUserRoles");
            DropForeignKey("dbo.UserRoles", "UserId", "dbo.Users");
            DropForeignKey("dbo.CustomUserLogins", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.CustomUserClaims", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.CustomUserRoles", "CustomRole_Id", "dbo.CustomRoles");
            DropForeignKey("dbo.MandateHistories", "MandateId", "dbo.Mandates");
            DropForeignKey("dbo.Questions", "applicant_Id", "dbo.Applicant");
            DropForeignKey("dbo.RDVs", "ApplicantId", "dbo.Applicant");
            DropForeignKey("dbo.Arrivals", "ArrivalId", "dbo.Applicant");
            DropForeignKey("dbo.ApplicantRessources", "ressourceId", "dbo.Ressource");
            DropForeignKey("dbo.Leaves", "Ressource_Id", "dbo.Ressource");
            DropForeignKey("dbo.Discussions", "ressourceId", "dbo.Ressource");
            DropForeignKey("dbo.Messages", "Discussion_DiscId", "dbo.Discussions");
            DropForeignKey("dbo.Discussions", "clientId", "dbo.Client");
            DropForeignKey("dbo.Requests", "Client_Id", "dbo.Client");
            DropForeignKey("dbo.OrganizationCharts", "Ressource_Id", "dbo.Ressource");
            DropForeignKey("dbo.RessourceSkills", "Skill_SkillId", "dbo.Skills");
            DropForeignKey("dbo.RessourceSkills", "Ressource_Id", "dbo.Ressource");
            DropForeignKey("dbo.ProjectSkills", "Skill_SkillId", "dbo.Skills");
            DropForeignKey("dbo.ProjectSkills", "Project_ProjectId", "dbo.Projects");
            DropForeignKey("dbo.OrganizationCharts", "Project_ProjectId", "dbo.Projects");
            DropForeignKey("dbo.Mandates", "ressource_Id", "dbo.Ressource");
            DropForeignKey("dbo.Mandates", "project_ProjectId", "dbo.Projects");
            DropForeignKey("dbo.OrganizationCharts", "Client_Id", "dbo.Client");
            DropForeignKey("dbo.ApplicantRessources", "applicantId", "dbo.Applicant");
            DropForeignKey("dbo.ApplicantRequests", "ApplicantRequestId", "dbo.Applicant");
            DropForeignKey("dbo.ApplicantAnswers", "questionId", "dbo.Questions");
            DropForeignKey("dbo.ApplicantAnswers", "applicantId", "dbo.Applicant");
            DropForeignKey("dbo.Answers", "questionId", "dbo.Questions");
            DropIndex("dbo.Ressource", new[] { "Id" });
            DropIndex("dbo.Client", new[] { "Id" });
            DropIndex("dbo.Applicant", new[] { "Id" });
            DropIndex("dbo.UserRoles", new[] { "RoleId" });
            DropIndex("dbo.UserRoles", new[] { "UserId" });
            DropIndex("dbo.MandateHistories", new[] { "MandateId" });
            DropIndex("dbo.RDVs", new[] { "ApplicantId" });
            DropIndex("dbo.Arrivals", new[] { "ArrivalId" });
            DropIndex("dbo.Leaves", new[] { "Ressource_Id" });
            DropIndex("dbo.Messages", new[] { "Discussion_DiscId" });
            DropIndex("dbo.CustomUserRoles", new[] { "CustomRole_Id" });
            DropIndex("dbo.Requests", new[] { "Client_Id" });
            DropIndex("dbo.RessourceSkills", new[] { "Skill_SkillId" });
            DropIndex("dbo.RessourceSkills", new[] { "Ressource_Id" });
            DropIndex("dbo.ProjectSkills", new[] { "Skill_SkillId" });
            DropIndex("dbo.ProjectSkills", new[] { "Project_ProjectId" });
            DropIndex("dbo.Mandates", new[] { "ressource_Id" });
            DropIndex("dbo.Mandates", new[] { "project_ProjectId" });
            DropIndex("dbo.OrganizationCharts", new[] { "Ressource_Id" });
            DropIndex("dbo.OrganizationCharts", new[] { "Project_ProjectId" });
            DropIndex("dbo.OrganizationCharts", new[] { "Client_Id" });
            DropIndex("dbo.CustomUserLogins", new[] { "Users_Id" });
            DropIndex("dbo.Discussions", new[] { "ressourceId" });
            DropIndex("dbo.Discussions", new[] { "clientId" });
            DropIndex("dbo.CustomUserClaims", new[] { "Users_Id" });
            DropIndex("dbo.ApplicantRessources", new[] { "applicantId" });
            DropIndex("dbo.ApplicantRessources", new[] { "ressourceId" });
            DropIndex("dbo.ApplicantRequests", new[] { "ApplicantRequestId" });
            DropIndex("dbo.ApplicantAnswers", new[] { "questionId" });
            DropIndex("dbo.ApplicantAnswers", new[] { "applicantId" });
            DropIndex("dbo.Questions", new[] { "applicant_Id" });
            DropIndex("dbo.Answers", new[] { "questionId" });
            DropTable("dbo.Ressource");
            DropTable("dbo.Client");
            DropTable("dbo.Applicant");
            DropTable("dbo.UserRoles");
            DropTable("dbo.CustomRoles");
            DropTable("dbo.MandateHistories");
            DropTable("dbo.RDVs");
            DropTable("dbo.Arrivals");
            DropTable("dbo.Leaves");
            DropTable("dbo.Messages");
            DropTable("dbo.CustomUserRoles");
            DropTable("dbo.Requests");
            DropTable("dbo.RessourceSkills");
            DropTable("dbo.Skills");
            DropTable("dbo.ProjectSkills");
            DropTable("dbo.Mandates");
            DropTable("dbo.Projects");
            DropTable("dbo.OrganizationCharts");
            DropTable("dbo.CustomUserLogins");
            DropTable("dbo.Discussions");
            DropTable("dbo.CustomUserClaims");
            DropTable("dbo.ApplicantRessources");
            DropTable("dbo.ApplicantRequests");
            DropTable("dbo.ApplicantAnswers");
            DropTable("dbo.Users");
            DropTable("dbo.Questions");
            DropTable("dbo.Answers");
        }
    }
}
