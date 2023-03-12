using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
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
           if (CheckIfTonerSerialNumberExist(toner.SerialNumber).Success)
            {
                _tonerDal.Add(toner);
                return new SuccessResult(Messages.TonerAdded);
            }
            return new ErrorResult();
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


        private IResult CheckIfTonerSerialNumberExist(string printerSerialNumber)
        {

            var result = _tonerDal.GetAll(p => p.SerialNumber == printerSerialNumber).Any();
            if (result)
            {
                return new ErrorResult(Messages.PrinterSerialNumberExists);

            }
            return new SuccessResult();

        }
    }
}
