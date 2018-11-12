using Data.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data.Repositories.SkillsRepositories;

namespace Data.Repositories
{
    public class SkillsRepositories : RepositoryBase<Domain.Entity.Skill>, ISkillsRepositories
    {
        public SkillsRepositories(IDatabaseFactory dbFactory) : base(dbFactory)
        {
        }
        public interface ISkillsRepositories : IRepositoryBase<Domain.Entity.Skill>
        {

        }
    }
}
