using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfTonerDal : EfEntityRepositoryBase<Toner, mcbüContext>, ITonerDal

    {
        public List<TonerDto> GetTonerDtos()
        {
            using (mcbüContext context = new mcbüContext())
            {
                var result = from toner in context.Toners
                             join brand in context.TonerBrands on toner.BrandId equals brand.Id
                             join model in context.TonerModels on toner.ModelId equals model.Id


                             select new TonerDto {
                                 Id=toner.Id,
                                 SerialNumber=toner.SerialNumber,
                                 BrandId=brand.Id,
                                 BrandName=brand.BrandName,
                                 ModelId=model.Id,
                                 ModelName=model.ModelName,
                                 TonerRefilling = (from tracking in context.TonerTrackings
                                              where tracking.TonerId == toner.Id
                                              select tracking.TonerRefilling).FirstOrDefault()
                             };
                return result.ToList();
            }
        }
    }
}
