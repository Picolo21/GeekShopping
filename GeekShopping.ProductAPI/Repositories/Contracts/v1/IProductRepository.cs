using GeekShopping.ProductAPI.Data.ValueObjects.v1;

namespace GeekShopping.ProductAPI.Repositories.Contracts.v1;

public interface IProductRepository
{
    Task<IEnumerable<ProductVO>> FindAllAsync();
    Task<ProductVO> FindByIdAsync(int id);
    Task<ProductVO> CreateAsync(ProductVO product);
    Task<ProductVO> UpdateAsync(ProductVO product);
    Task<bool> DeleteAsync(int id);
}
