using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IEnumerable<object> GetAllByUnitPrice(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<object> GetAllByCategoryId(int v)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAlByCategoryId(int id)
        {
            return _productDal.GetAll(p => p.CategoryId == id);
        }

        public List<Product> GetAll()
        {
            //is kodlari
            //Yetkisi var mi ?

            return _productDal.GetAll();
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p=>p.UnitPrice>= min && p.UnitPrice<=max);
        }
    }
}
