using Data.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data.Repositories.RDVsRepositories;

namespace Data.Repositories
{
    public class RDVsRepositories : RepositoryBase<Domain.Entity.RDV>, IRDVsRepositories
    {
        public RDVsRepositories(IDatabaseFactory dbFactory) : base(dbFactory)
        {
        }
        public interface IRDVsRepositories : IRepositoryBase<Domain.Entity.RDV>
        {

        }
    }
}
