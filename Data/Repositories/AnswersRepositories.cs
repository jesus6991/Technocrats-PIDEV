using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Repositories;
using Data.Infrastructures;
using static Data.Repositories.AnswersRepositories;

namespace Data.Repositories
{
    public class AnswersRepositories : RepositoryBase<Domain.Entity.Answer>, IAnswersRepositories
    {
        public AnswersRepositories(IDatabaseFactory dbFactory) : base(dbFactory)
        {
        }
        public interface IAnswersRepositories : IRepositoryBase<Domain.Entity.Answer>
        {

        }
    }
}
