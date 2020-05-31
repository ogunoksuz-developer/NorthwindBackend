using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccsess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ICategoryDal: IEntityRepository<Category>
    {
    }
}
