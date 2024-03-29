﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class FeatureManager : IFeaturetService
    {
        IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void Add(Feature t)
        {
            _featureDal.Add(t);
        }

        public void Delete(Feature t)
        {
            _featureDal.Delete(t);
        }

        public Feature GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Feature> GetList()
        {
           return _featureDal.GetList();
        }

        public void Update(Feature t)
        {
            _featureDal.Update(t);
        }
    }
}
