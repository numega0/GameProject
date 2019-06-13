using Core.DataAccess.EntityFramework.Repository;
using GameProject.Dal.Abstract;
using GameProject.Dal.Concrete.EntityFramework.Context;
using GameProject.Entity.Concrete;

namespace GameProject.Dal.Concrete.EntityFramework
{

    public class EfUserDal : EfEntityRepositoryBase<User, DatabaseContext>, IUserDal
    {
    }

}
