using eShop.Domain.Entities;

namespace eShop.Application.Contracts.Persistence.Products;

public interface IProductService
{
    Task AddAsync(Product product);
}
