using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SubAboutManager : ISubAboutService
    {
        ISubAboutDal _subAboutDal;

        public SubAboutManager(ISubAboutDal subAboutDal)
        {
            _subAboutDal = subAboutDal;
        }

        public void Add(SubAbout t)
        {
            _subAboutDal.Add(t);
        }

        public void Delete(SubAbout t)
        {
            _subAboutDal.Delete(t);
        }

        public SubAbout GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<SubAbout> GetList()
        {
            return _subAboutDal.GetList();
        }

        public void Update(SubAbout t)
        {
            _subAboutDal.Update(t);
        }
    }
}
