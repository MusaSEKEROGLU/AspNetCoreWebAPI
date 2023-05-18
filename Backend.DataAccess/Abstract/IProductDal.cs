using Backend.Entities.Concrete;
using Backend.Shared.DataAccess;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Backend.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {

    }
}
