using Domain.Models;

namespace Application.Services;

public class ProductService
{
    public Product DuplicateProduct(Product originalProduct,
                                    decimal newPrice,
                                    int newStock)
    {
        Product clonedProduct = originalProduct.Clone();
        clonedProduct.Price = newPrice;
        clonedProduct.Stock = newStock;
        return clonedProduct;
    }
}
