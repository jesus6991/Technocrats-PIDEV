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
    public class ApplicantService : Service<Applicant>
    {
        private static IDatabaseFactory dbf = new DatabaseFactory();
        private static IUnitOfWork ut = new UnitOfWork(dbf);

        public ApplicantService() : base(ut)
        {
        }

        public Boolean ApplicantExist(int id)
        {
            Applicant a=new Applicant();
            try
            {
                a = ut.getRepository<Applicant>().GetById(id);
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