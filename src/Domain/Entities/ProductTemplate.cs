namespace Domain.Entities;

public class ProductTemplate(
    int id,
    string name,
    string description, 
    decimal price, 
    string category)
{
    public int Id { get; set; } = id;
    public string Name { get; set; } = name;
    public string Description { get; set; } = description;
    public decimal Price { get; set; } = price;
    public string Category { get; set; } = category;

    // Implement the Clone method
    public object Clone()
    {
        return new ProductTemplate(Id, Name, Description, Price, Category)
        {
            Id = this.Id // Copy the same ID or generate a new one if needed
        };
    }
}
