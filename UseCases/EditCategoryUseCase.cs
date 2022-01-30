using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class EditCategoryUseCase : IEditCategoryUseCase
    {
        private readonly ICategoryRepository CategoryRepository;
        public EditCategoryUseCase(ICategoryRepository categoryRepository)
        {
            this.CategoryRepository = categoryRepository;
        }

        public void Execute(Category category)
        {
            CategoryRepository.UpdateCategory(category);
        }
    }
}
