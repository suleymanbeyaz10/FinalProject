﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetAll();
        IDataResult<Category> GetById(int categoryId);
        
        
    }
}
