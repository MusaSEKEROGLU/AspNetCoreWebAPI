using Backend.Entities.Concrete;
using Backend.Shared.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetList();
        IDataResult<Product> GetById(int productId);
        IDataResult<List<Product>> GetListByCategory(int categoryId);
        IResult Add(Product product);
        IResult Update(Product product);
        IResult Delete(Product product);
    }
}
 