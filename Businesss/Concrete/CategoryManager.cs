using Businesss.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Businesss.Concrete
{
    public class CategoryManager : ICategoryManager
    {

        private readonly ICategoryDal _categoryDal;

        public CategoryManager()
        {
            
        }

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
           _categoryDal.Add(category);

            if (category.CategoryId==0)
            {
                Console.WriteLine("Gecersiz id girişi");
            }

        }

        public void Delete(int CategoryId)
        {
           _categoryDal.Delete(CategoryId);
        }

        public List<Category> GetAll()
        {
           _categoryDal.GetAll();

            return null;
        }

        public Category GetById(int Id)
        {
           _categoryDal.GetById(Id);

            if (GetById==null)
            {
                Console.WriteLine("Geçersiz id");
            }
            return null;
        }

        public void Update(int categoryId, Category updatedCategory)
        {
            _categoryDal.Update(categoryId, updatedCategory);
        }
    }
}
