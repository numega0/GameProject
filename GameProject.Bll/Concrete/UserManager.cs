using Core.Aspects.Postsharp.ValidationAspects;
using GameProject.Bll.ValidationRules.FluentValidation;
using GameProject.Dal.Abstract;
using GameProject.Entity.Concrete;
using GameProject.Interfaces;
using System.Collections.Generic;

namespace GameProject.Bll.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        [FluentValidationAspect(typeof(UserValidator))]
        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public void Update(User user)
        {
            _userDal.Update(user);
        }

        public void Delete(User user)
        {
            _userDal.Delete(user);
        }

        public User Get(User user)
        {
            return _userDal.Get(u => u.Id == user.Id);
        }

        public User GetUserByUserName(string username)
        {
            return _userDal.Get(u => u.UserName == username);
        }

        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }

        public bool Auth(User user)
        {
            User dbUser = _userDal.Get(u => u.UserName == user.UserName && u.Password == user.Password);
            return dbUser == null ? false : true;
        }

        public bool Check(User user)
        {
            User dbUser = _userDal.Get(u => u.UserName == user.UserName);
            return dbUser == null ? false : true;
        }

    }
}
