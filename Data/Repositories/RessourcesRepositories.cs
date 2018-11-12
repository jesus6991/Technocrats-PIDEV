using Data.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data.Repositories.RessourcesRepositories;

namespace Data.Repositories
{
    public class RessourcesRepositories : RepositoryBase<Domain.Entity.Ressource>, IRessourcesRepositories
    {
        public RessourcesRepositories(IDatabaseFactory dbFactory) : base(dbFactory)
        {
        }
        public interface IRessourcesRepositories : IRepositoryBase<Domain.Entity.Ressource>
        {

        }
    }
}
