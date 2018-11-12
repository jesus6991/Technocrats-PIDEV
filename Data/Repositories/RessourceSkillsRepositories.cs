using Data.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data.Repositories.RessourceSkillsRepositories;

namespace Data.Repositories
{
    public class RessourceSkillsRepositories : RepositoryBase<Domain.Entity.RessourceSkill>, IRessourceSkillsRepositories
    {
        public RessourceSkillsRepositories(IDatabaseFactory dbFactory) : base(dbFactory)
        {
        }
        public interface IRessourceSkillsRepositories : IRepositoryBase<Domain.Entity.RessourceSkill>
        {

        }
    }

}

