using Data.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data.Repositories.ApplicantRequestsRepositories;

namespace Data.Repositories
{
    public class ApplicantRequestsRepositories : RepositoryBase<Domain.Entity.ApplicantRequest>, IApplicantRequestsRepositories
    {
        public ApplicantRequestsRepositories(IDatabaseFactory dbFactory) : base(dbFactory)
        {
        }
        public interface IApplicantRequestsRepositories : IRepositoryBase<Domain.Entity.ApplicantRequest>
        {

        }
    }
}
