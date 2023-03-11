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
    public class PrinterBrandManager :IPrinterBrandService
    {
        IPrinterBrandDal _printerBrandDal;

        public PrinterBrandManager(IPrinterBrandDal printerBrandDal)
        {
            _printerBrandDal = printerBrandDal;
        }
        public IResult Add(PrinterBrand printerBrand)
        {
            _printerBrandDal.Add(printerBrand);
            return new SuccessResult(Messages.TonerAdded);
        }

        public IResult Delete(PrinterBrand printerBrand)
        {
            _printerBrandDal.Delete(printerBrand);
            return new SuccessResult(Messages.TonerAdded);
        }

        public IDataResult<List<PrinterBrand>> GetAll()
        {
            return new SuccessDataResult<List<PrinterBrand>>(_printerBrandDal.GetAll(), Messages.TonersListed);
        }

        public IResult Update(PrinterBrand printerBrand)
        {
            _printerBrandDal.Update(printerBrand);
            return new SuccessResult(Messages.TonerAdded);
        }
    }
}
