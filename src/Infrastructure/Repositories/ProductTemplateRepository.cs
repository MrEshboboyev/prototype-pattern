using Application.Interfaces;
using Domain.Entities;

namespace Infrastructure.Repositories;

public class ProductTemplateRepository : IProductTemplateRepository
{
    private readonly List<ProductTemplate> _productTemplates = 
        [
            new ProductTemplate(1, "Product 1", "Description 1", 100, "Category 1"),
            new ProductTemplate(2, "Product 2", "Description 2", 200, "Category 2"),
            new ProductTemplate(3, "Product 3", "Description 3", 300, "Category 3")
        ];

    public ProductTemplate? GetById(int id)
    {
        return _productTemplates.FirstOrDefault(pt => pt.Id == id);
    }

    public void Add(ProductTemplate productTemplate)
    {
        _productTemplates.Add(productTemplate);
    }
}
