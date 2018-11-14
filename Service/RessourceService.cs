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
    public class RessourceService : Service<Ressource>
    {
        private static IDatabaseFactory dbf = new DatabaseFactory();
        private static IUnitOfWork ut = new UnitOfWork(dbf);

        public RessourceService() : base(ut)
        {
        }

        public Boolean RessourceExist(int id)
        {
            Ressource a = new Ressource();
            try
            {
                a = ut.getRepository<Ressource>().GetById(id);
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
