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
    public class TonerBrandManager :ITonerBrandService
    {
        ITonerBrandDal _tonerBrandDal;

        public TonerBrandManager(ITonerBrandDal tonerBrandDal)
        {
            _tonerBrandDal = tonerBrandDal;
        }
        public IResult Add(TonerBrand tonerModel)
        {
            _tonerBrandDal.Add(tonerModel);
            return new SuccessResult(Messages.TonerAdded);
        }

        public IResult Delete(TonerBrand tonerBrand)
        {
            _tonerBrandDal.Delete(tonerBrand);
            return new SuccessResult(Messages.TonerAdded);
        }

        public IDataResult<List<TonerBrand>> GetAll()
        {
            return new SuccessDataResult<List<TonerBrand>>(_tonerBrandDal.GetAll(), Messages.TonersListed);
        }

        public IResult Update(TonerBrand tonerBrand)
        {
            _tonerBrandDal.Update(tonerBrand);
            return new SuccessResult(Messages.TonerAdded);
        }
    }
}
