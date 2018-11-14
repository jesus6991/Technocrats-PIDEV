using Data.Infrastructures;
using Domain.Entity;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ClientService : Service<Client>
    {
        private static IDatabaseFactory dbf = new DatabaseFactory(); 
        private static IUnitOfWork ut = new UnitOfWork(dbf);

        public ClientService() : base(ut)
        {
        }

        public Boolean ClientExist(int id)
        {
            Client a = new Client();
            try
            {
                a = ut.getRepository<Client>().GetById(id);
            }
            catch
            {
                a = null;
            }
            if (a == null)
                return false;
            return true;
        }


    }
}
