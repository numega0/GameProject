using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Entity.Concrete;

namespace GameProject.Interfaces
{
    public interface IUserService
    {
        void Add(User user);
        void Update(User user);
        void Delete(User user);

        User Get(User user);
        User GetUserByUserName(string username);
        List<User> GetAll();

        bool Auth(User user);
        bool Check(User user);
    }
}
