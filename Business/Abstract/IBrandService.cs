﻿using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetAll();
        IDataResult<Brand> GetById(int brandId);
        IResult Add(Brand brand);
        IResult Update(Brand brand);
        IResult Remove (Brand brand);
        IResult AddTransactionalTest(Brand brand);
    }
}