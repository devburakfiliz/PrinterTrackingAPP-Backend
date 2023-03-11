using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPrinterModelService
    {
        IDataResult<List<PrinterModel>> GetAll();
        IResult Add(PrinterModel printerModel);
        IResult Delete(PrinterModel printerModel);
        IResult Update(PrinterModel printerModel);
    }
}
