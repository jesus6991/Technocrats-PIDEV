using Data.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data.Repositories.RequestsRepositories;

namespace Data.Repositories
{
    public class RequestsRepositories : RepositoryBase<Domain.Entity.Request>, IRequestsRepositories
    {
        public RequestsRepositories(IDatabaseFactory dbFactory) : base(dbFactory)
        {
        }
        public interface IRequestsRepositories : IRepositoryBase<Domain.Entity.Request>
        {

        }
    }
}
