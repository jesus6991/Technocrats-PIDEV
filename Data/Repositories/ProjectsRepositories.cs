using Data.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data.Repositories.ProjectsRepositories;

namespace Data.Repositories
{
    public class ProjectsRepositories : RepositoryBase<Domain.Entity.Project>, IProjectsRepositories
    {
        public ProjectsRepositories(IDatabaseFactory dbFactory) : base(dbFactory)
        {
        }
        public interface IProjectsRepositories : IRepositoryBase<Domain.Entity.Project>
        {

        }
    }
}
