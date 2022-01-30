using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class AddCategoryUseCase : IAddCategoryUseCase
    {
        private readonly ICategoryRepository categoryRepository;
        public AddCategoryUseCase(ICategoryRepository _categoryRepository)
        {
            this.categoryRepository = _categoryRepository;

        }
        public void Execute(Category category)
        {
            categoryRepository.AddCategory(category);
        }

    }
}
