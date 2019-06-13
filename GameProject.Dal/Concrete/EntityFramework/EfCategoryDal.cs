using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework.Repository;
using GameProject.Dal.Abstract;
using GameProject.Dal.Concrete.EntityFramework.Context;
using GameProject.Entity.Concrete;

namespace GameProject.Dal.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, DatabaseContext>, ICategoryDal
    {
    }
}
