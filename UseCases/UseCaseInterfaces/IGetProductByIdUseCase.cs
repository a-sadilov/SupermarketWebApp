using CoreBusiness;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public interface IGetProductByIdUseCase
    {
        Product Execute(int productId);
    }
}