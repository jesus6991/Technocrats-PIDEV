using Data.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data.Repositories.ArrivalsRepositories;

namespace Data.Repositories
{
    public class ArrivalsRepositories : RepositoryBase<Domain.Entity.Arrival>, IArrivalsRepositories
    {
        public ArrivalsRepositories(IDatabaseFactory dbFactory) : base(dbFactory)
        {
        }
        public interface IArrivalsRepositories : IRepositoryBase<Domain.Entity.Arrival>
        {

        }
    }
}
