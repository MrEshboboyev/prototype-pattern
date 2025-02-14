using Domain.Entities;

namespace Application.Interfaces;

public interface IProductTemplateRepository
{
    ProductTemplate? GetById(int id);
    void Add(ProductTemplate productTemplate);
}