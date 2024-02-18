using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesss.Abstract
{
    public interface ICategoryManager
    {
        void Add(Category category);

        void Delete(int CategoryId);

        List<Category> GetAll();

        Category GetById(int Id);

        void Update(int categoryId, Category updatedCategory);


    }
}
