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
    public class PrinterModelManager : IPrinterModelService
    {
        IPrinterModelDal _printerModelDal;

        public PrinterModelManager(IPrinterModelDal printerModelDal)
        {
            _printerModelDal = printerModelDal;
        }

        public IResult Add(PrinterModel printerModel)
        {
            _printerModelDal.Add(printerModel);
            return new SuccessResult(Messages.TonerAdded);
        }

        public IResult Delete(PrinterModel printerModel)
        {
            _printerModelDal.Delete(printerModel);
            return new SuccessResult(Messages.TonerAdded);
        }

        public IDataResult<List<PrinterModel>> GetAll()
        {
            return new SuccessDataResult<List<PrinterModel>>(_printerModelDal.GetAll(), Messages.TonersListed);
        }

        public IResult Update(PrinterModel printerModel)
        {
            _printerModelDal.Update(printerModel);
            return new SuccessResult(Messages.TonerAdded);
        }
    }
}
