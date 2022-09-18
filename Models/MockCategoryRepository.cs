using System.Collections.Generic;

namespace BethanysPieShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category {CategoryId=1, CategoryName="Fruit Pies", Description="Fruit Pie Description"},
                new Category {CategoryId=2, CategoryName="Cheese Cakes", Description="Cheese Cake Description"},
                new Category {CategoryId=3, CategoryName="Seasonal Pies", Description="Seasonal Pie Description"}
            };
    }
}
    