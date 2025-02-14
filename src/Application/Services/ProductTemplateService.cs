using Application.Interfaces;
using Domain.Entities;

namespace Application.Services;

public class ProductTemplateService(IProductTemplateRepository productTemplateRepository)
{
    public ProductTemplate CloneProductTemplate(int templateId)
    {
        var template = productTemplateRepository.GetById(templateId) 
            ?? throw new ArgumentException("Template not found");

        var clonedTemplate = (ProductTemplate)template.Clone();
        productTemplateRepository.Add(clonedTemplate);

        return clonedTemplate;
    }
}