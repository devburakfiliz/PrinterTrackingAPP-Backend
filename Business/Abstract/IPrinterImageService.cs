using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPrinterImageService
    {
        IResult Add(IFormFile file, PrinterImage printerImage);
        IResult Delete(PrinterImage printerImage);
        IResult Update(IFormFile file, PrinterImage printerImage);

        IDataResult<List<PrinterImage>> GetAll();
        IDataResult<List<PrinterImage>> GetByCarId(int printerImage);
        IDataResult<PrinterImage> GetByImageId(int imageId);
    }
}
