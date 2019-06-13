using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Xml.Xsl;
using GameProject.Bll.Concrete;
using GameProject.Dal.Abstract;
using GameProject.Dal.Concrete.EntityFramework;
using GameProject.Interfaces;
using GameProject.MvcUI.Security;
using Ninject;

namespace GameProject.MvcUI.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private readonly IKernel _ninjectKernel;


        public NinjectControllerFactory()
        {
            _ninjectKernel = new StandardKernel();

            AddDalBindings();
            AddBllBindings();

        }

        private void AddDalBindings()
        {
            _ninjectKernel.Bind<IUserDal>().To<EfUserDal>();
            _ninjectKernel.Bind<ICategoryDal>().To<EfCategoryDal>();
            _ninjectKernel.Bind<IGameDal>().To<EfGameDal>();

        }

        private void AddBllBindings()
        {
            _ninjectKernel.Bind<IUserService>().To<UserManager>();
            _ninjectKernel.Bind<ICategoryService>().To<CategoryManager>();
            _ninjectKernel.Bind<IGameService>().To<GameManager>();


        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ?
                null :
                (IController)_ninjectKernel.Get(controllerType);
        }




    }
}