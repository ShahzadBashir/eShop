using eShop.Domain.ValueObjects;

namespace eShop.Domain.Entities;

public class Product
{
    private Product()
    {
        
    }
    private Product(ProductId productId, string name, Money price, Sku sku)
    {
        Id = productId;
        Name = name;
        Price = price;
        Sku = sku;
    }
    public ProductId Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public Money Price { get; private set; }
    public Sku Sku { get; private set; }
    public static Product Create(ProductId productId, string name, Money price, Sku sku)
    {
        return new Product(productId, name, price, sku);
    }
}