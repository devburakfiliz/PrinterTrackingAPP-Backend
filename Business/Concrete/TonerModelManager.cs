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
    public class TonerModelManager: ITonerModelService
    {
        ITonerModelDal _tonerModelDal;

        public TonerModelManager(ITonerModelDal tonerModelDal)
        {
            _tonerModelDal = tonerModelDal;
        }
        public IResult Add(TonerModel tonerModel)
        {
            _tonerModelDal.Add(tonerModel);
            return new SuccessResult(Messages.TonerAdded);
        }

        public IResult Delete(TonerModel tonerModel)
        {
            _tonerModelDal.Delete(tonerModel);
            return new SuccessResult(Messages.TonerAdded);
        }

        public IDataResult<List<TonerModel>> GetAll()
        {
            return new SuccessDataResult<List<TonerModel>>(_tonerModelDal.GetAll(), Messages.TonersListed);
        }

        public IResult Update(TonerModel tonerModel)
        {
            _tonerModelDal.Update(tonerModel);
            return new SuccessResult(Messages.TonerAdded);
        }
    }
}
