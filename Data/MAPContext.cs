using Microsoft.AspNet.Identity.EntityFramework;
using Domain.Entity;
using System.Data.Entity;

namespace Data
{
   public class MAPContext : IdentityDbContext<Users, CustomRole, int, CustomUserLogin, CustomUserRole, CustomUserClaim>
    {
        public static MAPContext Create()
        {
            return new MAPContext();
        }

        static MAPContext()
        {
            Database.SetInitializer<MAPContext>(null);
        }
        public MAPContext() : base("name=DefaultConnection")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Client>().ToTable("Client");
            modelBuilder.Entity<Ressource>().ToTable("Ressource");
            modelBuilder.Entity<Applicant>().ToTable("Applicant");
            modelBuilder.Entity<Users>().ToTable("Users");

            modelBuilder.Entity<Users>()
            .HasMany(u => u.Roles)
            .WithMany()
            .Map(m => {
                m.ToTable("UserRoles");
                m.MapLeftKey("UserId");
                m.MapRightKey("RoleId");
            });

            modelBuilder.Entity<Applicant>()
                       .HasRequired(s => s.arrival)
                       .WithRequiredPrincipal(ad => ad.Applicant);
            modelBuilder.Entity<Applicant>()
                       .HasRequired(s => s.applicantRequest)
                       .WithRequiredPrincipal(ad => ad.Applicant);

        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Ressource> Ressources { get; set; }
        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<ApplicantAnswer> ApplicantAnswers { get; set; }
        public DbSet<ApplicantRequest> ApplicantRequests { get; set; }
        public DbSet<Arrival> Arrivals { get; set; }
        public DbSet<Discussion> Discussions { get; set; }
        public DbSet<Leave> Leaves { get; set; }
        public DbSet<Mandate> Mandates { get; set; }
        public DbSet<MandateHistory> MandateHistorys { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<OrganizationChart> OrganizationChartS { get; set; }
        public DbSet<Project> ProjectS { get; set; }
        public DbSet<ProjectSkill> ProjectSkillS { get; set; }
        public DbSet<Question> QuestionS { get; set; }
        public DbSet<RDV> RDVs { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<RessourceSkill> RessourceSkills { get; set; }
        public DbSet<ApplicantRessource> ApplicantRessources { get; set; }





    }
}
