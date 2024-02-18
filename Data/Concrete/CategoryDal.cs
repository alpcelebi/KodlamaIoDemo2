using Data.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Conrete
{
    public class CategoryDal : ICategoryDal
    {

        List<Category> _categories;


        public CategoryDal()
        {
            _categories = new List<Category>();
            _categories.Add(new Category(1, "C# Programlama"));
        }
        public void Add(Category category)
        {
           _categories.Add(category);   
        }

        public void Delete(int categoryId)
        {
            Category categoryToDelete = null;

            foreach (Category category in _categories)
            {

                if (category.CategoryId==categoryId)
                {
                    categoryToDelete = category;

                    break;
                }

                if (categoryToDelete!=null)
                {
                    _categories.Remove(categoryToDelete);

                    Console.WriteLine("Kategori silindi");
                }

                else
                {
                    Console.WriteLine("Kategori bulunamadı");
                }
            }
        }

        public List<Category> GetAll()
        {
            foreach (Category category in _categories)
            {
                Console.WriteLine("Kategoriler listelendi: " + category.CategoryName);
            }
            return _categories;
        }

        public Category GetById(int id)
        {
            foreach (Category category in _categories)
            {
                if (category.CategoryId == id)
                {
                    Console.WriteLine(category.CategoryName + " isimli kategori bulundu.");
                    return category;
                }
            }
            return null;

        }

        public void Update(int categoryId, Category updatedCategory)
        {
            foreach (Category category in _categories)
            {
                if (category.CategoryId==categoryId)
                {
                    category.CategoryName = updatedCategory.CategoryName;

                    Console.WriteLine("Kategori güncellemesi başarılı");

                    return;
                }
            }

            Console.WriteLine("Kategori Bulunamadı");

        }
    }
}
