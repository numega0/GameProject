using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework.Repository;
using GameProject.Entity.Concrete;

namespace GameProject.Dal.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
    }
}
