﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class BelencoManager : IBelencoService
    {
        IBelencoDal _belencoDal;

        public BelencoManager(IBelencoDal belencoDal)
        {
            _belencoDal = belencoDal;
        }
        public Belenco GetById(int id)
        {
            return _belencoDal.GetById(id);
        }
        public List<Belenco> GetBelencoByID(int id)
        {
            return _belencoDal.GetListAll(x=>x.Belenco_ID==id);
        }

        public List<Belenco> GetList()
        {
            return _belencoDal.GetListAll();
        }

        public void TAdd(Belenco t)
        {
            _belencoDal.Insert(t);
        }

        public void TDelete(Belenco t)
        {
            _belencoDal.Delete(t);
        }

        public void TUpdate(Belenco t)
        {
            _belencoDal.Update(t);
        }
    }
}
