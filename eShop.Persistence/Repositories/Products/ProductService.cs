using eShop.Application.Contracts.Persistence.Products;
using eShop.Domain.Entities;

namespace eShop.Persistence.Repositories.Products;

internal sealed class ProductService : IProductService
{
    private readonly ApplicationDbContext _context;

    public ProductService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Product product)
    {
        await _context.Products.AddAsync(product);
        await _context.SaveChangesAsync();
    }
}
