using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data.Repositories.ApplicantAnswerRepositories;
using Domain.Entity;
using System.Linq.Expressions;
using Data.Infrastructures;

namespace Data.Repositories
{
    public class ApplicantAnswerRepositories : RepositoryBase<Domain.Entity.ApplicantAnswer>, IApplicantAnswerRepositories
    {
        public ApplicantAnswerRepositories(IDatabaseFactory dbFactory) : base(dbFactory)
        {
        }

        public void Add(Skill entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Skill entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<Skill, bool>> where)
        {
            throw new NotImplementedException();
        }

        public Skill Get(Expression<Func<Skill, bool>> where)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Skill> GetMany(Expression<Func<Skill, bool>> where = null, Expression<Func<Skill, bool>> orderBy = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Skill entity)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Skill> IRepositoryBase<Skill>.GetAll()
        {
            throw new NotImplementedException();
        }


        Skill IRepositoryBase<Skill>.GetById(string id)
        {
            throw new NotImplementedException();
        }


        Skill IRepositoryBase<Skill>.GetById(long id)
        {
            throw new NotImplementedException();
        }

        public interface IApplicantAnswerRepositories : IRepositoryBase<Domain.Entity.Skill>
        {

        }
    }
}
