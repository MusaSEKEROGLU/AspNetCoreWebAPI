using Backend.DataAccess.Abstract;
using Backend.DataAccess.Concrete.EntityFramework.Contexts;
using Backend.Entities.Concrete;
using Backend.Shared.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product,BackendContext>,IProductDal
    {

    }
}
