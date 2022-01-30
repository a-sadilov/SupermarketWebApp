using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class CategoryInMemoryRepository : ICategoryRepository
    {
        private List<Category> categories;
        public CategoryInMemoryRepository() 
        {
            // Add some default categories

            this.categories = new List<Category>()
            {
                new Category { CategoryId = 1, Name ="Beverage", Description = "Beverage Description"},
                new Category { CategoryId = 2, Name ="Bekery", Description = "Bekery Description"},
                new Category { CategoryId = 3, Name ="Meat", Description = "Meat Description"}
            };
        }

        public void AddCategory(Category category)
        {
            if (categories.Any(x => x.Name.Equals(category.Name, StringComparison.OrdinalIgnoreCase))) return;
            var maxId = categories.Max(x => x.CategoryId);
            category.CategoryId = maxId + 1;

            categories.Add(category);
        }
        public void UpdateCategory(Category category)
        {
            var categorytoUpdate = GetCategoryById(category.CategoryId);
            if (categorytoUpdate != null)
            {
                categorytoUpdate.Name = category.Name;
                categorytoUpdate.Description = category.Description;
            }
        }
        public IEnumerable<Category> GetCategories()
        {
            return categories;
        }

        public Category GetCategoryById(int categoryId)
        {
            return categories?.FirstOrDefault(x => x.CategoryId == categoryId);
            
        }
    }
}
