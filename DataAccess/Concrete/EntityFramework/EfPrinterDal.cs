using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPrinterDal : EfEntityRepositoryBase<Printer, mcbüContext>, IPrinterDal
    {
       public List<PrinterDto> GetPrinterDtos()
        {
            using (mcbüContext context = new mcbüContext())
            {
                var result = from printer in context.Printers
                             join brand in context.PrinterBrands on printer.BrandId equals brand.Id
                             join model in context.PrinterModels on printer.ModelId equals model.Id


                             select new PrinterDto
                             {
                                Id =printer.Id,
                                SerialNumber=printer.SerialNumber,
                                BrandId=brand.Id,
                                BrandName=brand.BrandName,
                                ModelId=model.Id,
                                ModelName=model.ModelName,

                             };
                return result.ToList();
            }
        }

    }
}
