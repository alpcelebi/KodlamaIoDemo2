using System;

namespace Entities.Concrete
{
    public class Category
    {
        public Category(int categoryId, string categoryName)
        {
            CategoryId = categoryId;
            CategoryName = categoryName;
        }

        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
    }
}
