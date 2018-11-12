using Data.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data.Repositories.MandateHistorysRepositories;

namespace Data.Repositories
{
    public class MandateHistorysRepositories :RepositoryBase<Domain.Entity.MandateHistory>, IMandateHistorysRepositories
    {
        public MandateHistorysRepositories(IDatabaseFactory dbFactory) : base(dbFactory)
        {
        }
        public interface IMandateHistorysRepositories : IRepositoryBase<Domain.Entity.MandateHistory>
        {

        }
    }
}
