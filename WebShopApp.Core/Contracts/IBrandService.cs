using WebShopApp.Infrastructure.Data.Entities;

namespace WebShopApp.Core.Contracts
{
    public interface IBrandService
    {
        List<Brand> GetBrands();
        Brand GetBrandById(int brandId);
        List<Product> GetProductsByCategory(int brandId);
    }
}
