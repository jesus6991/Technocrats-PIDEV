using Data.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data.Repositories.LeavesRepositories;

namespace Data.Repositories
{
    public class LeavesRepositories : RepositoryBase<Domain.Entity.Leave>, ILeaveRepositories
    {
        public LeavesRepositories(IDatabaseFactory dbFactory) : base(dbFactory)
        {
        }
        public interface ILeaveRepositories : IRepositoryBase<Domain.Entity.Leave>
        {

        }
    }
}
