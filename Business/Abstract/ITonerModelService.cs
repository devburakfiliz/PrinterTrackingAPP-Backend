using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITonerModelService
    {
        IDataResult<List<TonerModel>> GetAll();
        IResult Add(TonerModel tonerModel);
        IResult Delete(TonerModel tonerModel);
        IResult Update(TonerModel tonerModel);
    }
}
