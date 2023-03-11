﻿using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class TonerManager : ITonerService
    {
        ITonerDal _tonerDal; 

        public TonerManager(ITonerDal tonerDal)
        {
            _tonerDal = tonerDal;
        }

        [SecuredOperation("storage,admin")]
        public IResult Add(Toner toner)
        {
            _tonerDal.Add(toner);
            return new SuccessResult(Messages.TonerAdded);
        }

        [SecuredOperation("storage,admin")]
        public IResult Delete(Toner toner)
        {
            _tonerDal.Delete(toner);
            return new SuccessResult(Messages.TonerDelete);
        }

        public IDataResult <List<Toner>> GetAll()
        {
            return new SuccessDataResult<List<Toner>>( _tonerDal.GetAll(),Messages.TonersListed);
        }



        public IDataResult<Toner> GetById(int tonerId)
        {
            return new SuccessDataResult<Toner>( _tonerDal.Get(c => c.Id == tonerId),Messages.TonerListed);

        }

        public IDataResult<List<TonerDto>> GetTonerDtos()
        {
            return new SuccessDataResult<List<TonerDto>>(_tonerDal.GetTonerDtos(), Messages.TonerListed);

        }


        [SecuredOperation("storage,admin")]
        public IResult Update(Toner toner)
        {
            _tonerDal.Update(toner);
            return new SuccessResult(Messages.TonerUpdated);
        }
    }
}
