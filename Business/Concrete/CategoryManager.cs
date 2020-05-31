﻿using Business.Abstract;
using Business.Contants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
   public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IResult Add(Category category)
        {
            _categoryDal.Add(category);
            return new SuccessResult(message: Messages.CategoryAdded);
        }

        public IResult Delete(Category category)
        {
            _categoryDal.Delete(category);
            return new SuccessResult(message: Messages.CategoryDeleted);
        }

        public IDataResult<Category> GetByID(int categoryId)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(filter: x=> x.CategoryId==categoryId));
        }

        public IDataResult<List<Category>> GetList()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetList().ToList());

        }

        public IResult Update(Category category)
        {
            _categoryDal.Update(category);
            return new SuccessResult(message: Messages.CategoryUpdated);
        }
    }
}
