using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITonerRefillingService
    {
        IDataResult<List<TonerRefilling>> GetAll();
        IResult Add(TonerRefilling tonerRefilling);
        IResult Delete(TonerRefilling tonerRefilling);
        IResult Update(TonerRefilling tonerRefilling);
    }
}
