using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TonerRefillingManager : ITonerRefillingService
    {
        ITonerRefillingDal _tonerRefillingDal;

        public TonerRefillingManager(ITonerRefillingDal tonerRefillingDal)
        {
            _tonerRefillingDal = tonerRefillingDal;
        }

        public IResult Add(TonerRefilling tonerRefilling)
        {
            _tonerRefillingDal.Add(tonerRefilling);
            return new SuccessResult(Messages.RefillingAdded);
        }

        public IResult Delete(TonerRefilling tonerRefilling)
        {
            _tonerRefillingDal.Delete(tonerRefilling);
            return new SuccessResult(Messages.RefillingDelete);
        }

        public IDataResult<List<TonerRefilling>> GetAll()
        {
            return new SuccessDataResult<List<TonerRefilling>>(_tonerRefillingDal.GetAll(), Messages.RefillingListed);
        }

        public IResult Update(TonerRefilling tonerRefilling)
        {
            _tonerRefillingDal.Update(tonerRefilling);
            return new SuccessResult(Messages.RefillingUpdated);
        }
    }
}
