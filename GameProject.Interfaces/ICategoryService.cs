using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Entity.Concrete;

namespace GameProject.Interfaces
{
    public interface ICategoryService
    {
        Category GetCategoryById(int id);
        List<Category> GetAll();
        void Add(Category category);

    }
}
