using Data.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data.Repositories.ClientsRepositories;

namespace Data.Repositories
{
    public class ClientsRepositories : RepositoryBase<Domain.Entity.Client>, IClientsRepositories
    {
        public ClientsRepositories(IDatabaseFactory dbFactory) : base(dbFactory)
        {
        }
        public interface IClientsRepositories : IRepositoryBase<Domain.Entity.Client>
        {

        }
    }
}
