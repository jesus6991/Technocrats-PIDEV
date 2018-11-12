using Data.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data.Repositories.ProjectSkillsRepositories;

namespace Data.Repositories
{
    public class ProjectSkillsRepositories : RepositoryBase<Domain.Entity.ProjectSkill>, IProjectSkillsRepositories
    {
        public ProjectSkillsRepositories(IDatabaseFactory dbFactory) : base(dbFactory)
        {
        }
        public interface IProjectSkillsRepositories : IRepositoryBase<Domain.Entity.ProjectSkill>
        {

        }
    }
}
