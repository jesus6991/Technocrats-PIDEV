using Data.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data.Repositories.MandatesRepositories;

namespace Data.Repositories
{
    public class MandatesRepositories : RepositoryBase<Domain.Entity.Mandate>, IMandateRepositories
    {
        public MandatesRepositories(IDatabaseFactory dbFactory) : base(dbFactory)
        {
        }
        public interface IMandateRepositories : IRepositoryBase<Domain.Entity.Mandate>
        {

        }
    }
}
