using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TonerTrackingManager : ITonerTrackingService
    {

        ITonerTrackingDal _tonerTrackingDal;

        public TonerTrackingManager(ITonerTrackingDal tonerTrackingDal)
        {
            _tonerTrackingDal = tonerTrackingDal;
        }

        public IResult Add(TonerTracking tonerTracking)
        {
            _tonerTrackingDal.Add(tonerTracking);
            return new SuccessResult(Messages.PrinterAdded);
        }

        public IResult AddTransactionalTest(TonerTracking tonerTracking)
        {
            _tonerTrackingDal.Update(tonerTracking);
            _tonerTrackingDal.Add(tonerTracking);
            return new SuccessResult(Messages.PrinterUpdated);
        }

        public IResult Delete(TonerTracking tonerTracking)
        {
            _tonerTrackingDal.Delete(tonerTracking);
            return new SuccessResult(Messages.PrinterAdded);
        }

        public IDataResult<List<TonerTracking>> GetAll()
        {
            return new SuccessDataResult<List<TonerTracking>>(_tonerTrackingDal.GetAll(), Messages.PrintersListed);
        }

        public IDataResult<TonerTracking> GetById(int tonertrackingId)
        {
            return new SuccessDataResult<TonerTracking>(_tonerTrackingDal.Get(p => p.Id == tonertrackingId), Messages.PrinterListed);
        }

        public IDataResult<List<TonerTrackingDto>> GetTonerTrackingDtos()
        {
            return new SuccessDataResult<List<TonerTrackingDto>>(_tonerTrackingDal.GetTonerTrackingDtos(), Messages.PrinterListed);
        }

        public IResult Update(TonerTracking tonerTracking)
        {
            _tonerTrackingDal.Update(tonerTracking);
            return new SuccessResult(Messages.PrinterAdded);
        }
    }
}
