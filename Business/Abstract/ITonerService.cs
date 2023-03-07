﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ITonerService
    {
        IDataResult<List<Toner>> GetAll();
        IDataResult<Toner >GetById(int tonerId);
        IResult Add(Toner toner);
        IResult Delete(Toner toner);
        IResult Update(Toner toner);

    }
}
