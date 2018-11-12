using Data.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data.Repositories.ApplicantsRepositories;

namespace Data.Repositories
{
    public class ApplicantsRepositories : RepositoryBase<Domain.Entity.Applicant>, IApplicantsRepositories
    {
        public ApplicantsRepositories(IDatabaseFactory dbFactory) : base(dbFactory)
        {
        }
        public interface IApplicantsRepositories : IRepositoryBase<Domain.Entity.Applicant>
        {

        }
    }
}
