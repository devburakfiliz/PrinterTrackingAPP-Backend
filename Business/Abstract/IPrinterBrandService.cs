using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPrinterBrandService
    {
        IDataResult<List<PrinterBrand>> GetAll();
        IResult Add(PrinterBrand printerBrand);
        IResult Delete(PrinterBrand printerBrand);
        IResult Update(PrinterBrand printerBrand);
    }
}
