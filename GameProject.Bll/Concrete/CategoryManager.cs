using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Dal.Abstract;
using GameProject.Entity.Concrete;
using GameProject.Interfaces;

namespace GameProject.Bll.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public Category GetCategoryById(int id)
        {
            return _categoryDal.Get(c => c.Id == id, "Games.GameImage");
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }


    }
}
