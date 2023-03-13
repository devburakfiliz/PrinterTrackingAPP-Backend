using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfTonerTrackingDal : EfEntityRepositoryBase<TonerTracking, mcbüContext>, ITonerTrackingDal
    {
        public List<TonerTrackingDto> GetTonerTrackingDtos()
        {
            using (mcbüContext context = new mcbüContext())
            {
                var result = from tonertracking in context.TonerTrackings
                             join brand in context.TonerBrands on tonertracking.BrandId equals brand.Id
                             join toner in context.Toners on tonertracking.TonerId equals toner.Id
                             join model in context.TonerModels on tonertracking.ModelId equals model.Id
                            
                             
                             


                             select new TonerTrackingDto
                             {
                                 Id = tonertracking.Id,
                                 TonerId= toner.Id,
                                 SerialNumber = toner.SerialNumber,
                                 BrandId = brand.Id,
                                 BrandName = brand.BrandName,
                                 ModelId = model.Id,
                                 ModelName = model.ModelName,
                                 Description=tonertracking.Description,
                                 
                                



                             };
                return result.ToList();
            }
        }
    }
}
