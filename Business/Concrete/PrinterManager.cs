using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.CCS;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class PrinterManager : IPrinterService
    {



        IPrinterDal _printerDal;
       

        public PrinterManager(IPrinterDal printerDal)
        {
            _printerDal = printerDal;
           
            
        }


        //[SecuredOperation("add,admin")]
        //[ValidationAspect(typeof(ProductValidator))]
        //[CacheRemoveAspect("IProductService.Get")]
        public IResult Add(Printer printer)
        {
           
            _printerDal.Add(printer);
            return new SuccessResult(Messages.PrinterAdded);

        }

        [CacheAspect]
        [PerformanceAspect(5)] 
        public IDataResult<List<Printer>> GetAll()
        {
                return new SuccessDataResult<List<Printer>>(_printerDal.GetAll(), Messages.PrintersListed);       
        }

     

        [CacheAspect]
        public IDataResult<Printer> GetById(int printerId)
        {
            return new SuccessDataResult<Printer>(_printerDal.Get(p => p.Id == printerId),Messages.PrinterListed);
        }



        [CacheRemoveAspect("IProductService.Get")] 
        public IResult Update(Printer printer)
        {
            _printerDal.Update(printer);
            return new SuccessResult(Messages.PrinterUpdated);
        }

        


        [TransactionScopeAspect]
        public IResult AddTransactionalTest(Printer printer)
        {
            _printerDal.Update(printer);
            _printerDal.Add(printer);
            return new SuccessResult(Messages.PrinterUpdated);
        }

        public IResult Delete(Printer printer)
        {
            _printerDal.Delete(printer);
            return new SuccessResult(Messages.PrinterDelete);
        }

        public IDataResult<List<PrinterDto>> GetPrinterDtos()
        {
            return new SuccessDataResult<List<PrinterDto>>(_printerDal.GetPrinterDtos(), Messages.PrinterListed);

        }

     
    }
}


