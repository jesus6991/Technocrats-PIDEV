using Data.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data.Repositories.QuestionsRepositories;

namespace Data.Repositories
{
    public class QuestionsRepositories : RepositoryBase<Domain.Entity.Question>, IQuestionsRepositories
    {
        public QuestionsRepositories(IDatabaseFactory dbFactory) : base(dbFactory)
        {
        }
        public interface IQuestionsRepositories : IRepositoryBase<Domain.Entity.Question>
        {

        }
    }
}
