using Data.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data.Repositories.OrganizationChartsRepositories;

namespace Data.Repositories
{
    public class OrganizationChartsRepositories : RepositoryBase<Domain.Entity.OrganizationChart>, IOrganizationChartsRepositories
    {
        public OrganizationChartsRepositories(IDatabaseFactory dbFactory) : base(dbFactory)
        {
        }
        public interface IOrganizationChartsRepositories : IRepositoryBase<Domain.Entity.OrganizationChart>
        {

        }
    }
}
