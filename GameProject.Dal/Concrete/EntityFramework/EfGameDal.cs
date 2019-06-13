using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework.Repository;
using GameProject.Dal.Abstract;
using GameProject.Dal.Concrete.EntityFramework.Context;
using GameProject.Entity.Concrete;

namespace GameProject.Dal.Concrete.EntityFramework
{
    public class EfGameDal : EfEntityRepositoryBase<Game, DatabaseContext>, IGameDal
    {
    }
}
