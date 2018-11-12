using Data.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data.Repositories.DiscussionsRepositories;

namespace Data.Repositories
{
    public class DiscussionsRepositories : RepositoryBase<Domain.Entity.Discussion>, IDiscussionRepositories
    {
        public DiscussionsRepositories(IDatabaseFactory dbFactory) : base(dbFactory)
        {
        }
        public interface IDiscussionRepositories : IRepositoryBase<Domain.Entity.Discussion>
        {

        }
    }
}
