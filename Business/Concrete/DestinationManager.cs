﻿using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class DestinationManager:IDestinationService
    {
        IDestinationDal _destinationDal;
            public DestinationManager(IDestinationDal destinationDal)
        {
                _destinationDal = destinationDal;
        }

        public void TAdd(Destination t)
        {
            _destinationDal.Insert(t);
        }

        public void TDelete(Destination t)
        {
            _destinationDal.Delete(t);
        }

        public Destination TGetById(int id)
        {
            return _destinationDal.GetById(id);
        }

        public Destination TGetDestinationWithGuide(int id)
        {
            return _destinationDal.GetDestinationWithGuide(id);
        }

        public List<Destination> TGetLast4Destination()
        {
            return _destinationDal.GetLast4Destinations();
        }

        public List<Destination> TGetList()
        {
        return _destinationDal.GetList();
        }

        public void TUpdate(Destination t)
        {
             _destinationDal.Update(t);
        }
    }
}
