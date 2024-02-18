using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICategoryDal
    {
        void Add(Category category);
        void Delete(int categoryId);
        List<Category> GetAll();
        Category GetById(int id);
        void Update(int categoryId, Category updatedCategory);
    }
}
