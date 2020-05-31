using Business.Abstract;
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
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {
            _productDal.Add(product);
            return new SuccessResult(message: Messages.ProductAdded);
        }

        public IResult Delete(Product product)
        {
            _productDal.Delete(product);
            return new SuccessResult(message: Messages.ProductDeleted);
        }

        public IDataResult<Product> GetByID(int productId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(filter: x => x.ProductId == productId));
        }

        public IDataResult<List<Product>> GetList()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetList().ToList()) ;
        }

        public IDataResult<List<Product>> GetListByCategoryId(int categoryId)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetList(filter: x => x.CategoryId == categoryId).ToList());
        }

        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult(message:Messages.ProductUpdated);
        }

      }
}
