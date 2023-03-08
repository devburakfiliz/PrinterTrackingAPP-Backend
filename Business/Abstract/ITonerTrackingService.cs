using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITonerTrackingService 
    {
        IDataResult<List<TonerTracking>> GetAll();
        IDataResult<List<TonerTrackingDto>> GetTonerTrackingDtos();
        IDataResult<TonerTracking> GetById(int tonertrackingId);
        IResult Add(TonerTracking tonerTracking);
        IResult Delete(TonerTracking tonerTracking);
        IResult AddTransactionalTest(TonerTracking tonerTracking);
        IResult Update(TonerTracking tonerTracking);
    }
}
