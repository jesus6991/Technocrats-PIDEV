using Data.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Data.Repositories.MessagesRepositories;
using Domain.Entity;
using System.Linq.Expressions;

namespace Data.Repositories
{
    public class MessagesRepositories : RepositoryBase<Domain.Entity.Message>, IMessagesRepositories
    {
        public MessagesRepositories(IDatabaseFactory dbFactory) : base(dbFactory)
        {
        }

        public void Add(Mandate entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Mandate entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<Mandate, bool>> where)
        {
            throw new NotImplementedException();
        }

        public Mandate Get(Expression<Func<Mandate, bool>> where)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Mandate> GetMany(Expression<Func<Mandate, bool>> where = null, Expression<Func<Mandate, bool>> orderBy = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Mandate entity)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Mandate> IRepositoryBase<Mandate>.GetAll()
        {
            throw new NotImplementedException();
        }

        Mandate IRepositoryBase<Mandate>.GetById(string id)
        {
            throw new NotImplementedException();
        }

        Mandate IRepositoryBase<Mandate>.GetById(long id)
        {
            throw new NotImplementedException();
        }

        public interface IMessagesRepositories : IRepositoryBase<Domain.Entity.Mandate>
        {

        }
    }
}
