using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Helper.FileHelper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PrinterImageManager :IPrinterImageService
    {
        IPrinterImageDal _printerImageDal;
        IFileHelper _fileHelper;

        public PrinterImageManager(IPrinterImageDal printerImageDal, IFileHelper fileHelper)
        {
            _printerImageDal = printerImageDal;
            _fileHelper = fileHelper;
        }

        public IResult Add(IFormFile file, PrinterImage printerImage)
        {
           
            printerImage.ImagePath = _fileHelper.Upload(file, PathConstants.ImagesPath);
            printerImage.Date = DateTime.Now;
            _printerImageDal.Add(printerImage);
            return new SuccessResult("Resim başarıyla yüklendi");
        }

        public IResult Delete(PrinterImage printerImage)
        {
            _fileHelper.Delete(PathConstants.ImagesPath + printerImage.ImagePath);
            _printerImageDal.Delete(printerImage);
            return new SuccessResult();
        }

        public IDataResult<List<PrinterImage>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<PrinterImage>> GetByCarId(int printerId)
        {
            var result = BusinessRules.Run(CheckPrinterImage(printerId));
            if (result != null)
            {
                return new ErrorDataResult<List<PrinterImage>>(GetDefaultImage(printerId).Data);
            }
            return new SuccessDataResult<List<PrinterImage>>(_printerImageDal.GetAll(c => c.PrinterId == printerId));
        }

        public IDataResult<PrinterImage> GetByImageId(int imageId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(IFormFile file, PrinterImage printerImage)
        {
            printerImage.ImagePath = _fileHelper.Update(file, PathConstants.ImagesPath + printerImage.ImagePath, PathConstants.ImagesPath);
            _printerImageDal.Update(printerImage);
            return new SuccessResult();
        }
        private IResult CheckPrinterImage(int printerId)
        {
            var result = _printerImageDal.GetAll(c => c.PrinterId == printerId).Count;
            if (result > 0)
            {
                return new SuccessResult();
            }
            return new ErrorResult();
        }
        private IDataResult<List<PrinterImage>> GetDefaultImage(int carId)
        {

            List<PrinterImage> printerImage = new List<PrinterImage>();
            printerImage.Add(new PrinterImage { PrinterId = carId, Date = DateTime.Now, ImagePath = "DefaultImage.jpg" });
            return new SuccessDataResult<List<PrinterImage>>(printerImage);
        }
    }
}
