using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IPrinterService
    {
        IDataResult<List<Printer>> GetAll();
        IDataResult<Printer> GetById(int printerId);
        IResult Add(Printer printer);
        IResult Delete(Printer printer);
        IResult AddTransactionalTest(Printer printer);
        IResult Update(Printer product);
    }
}
