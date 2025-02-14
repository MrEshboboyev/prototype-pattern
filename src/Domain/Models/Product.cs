using Domain.Interfaces;

namespace Domain.Models;
public class Product(int id, string name, decimal price, int stock) : IPrototype<Product>
{
    public int Id { get; set; } = id;
    public string Name { get; set; } = name;
    public decimal Price { get; set; } = price;
    public int Stock { get; set; } = stock;

    public Product Clone()
    {
        return new Product(this.Id, this.Name, this.Price, this.Stock);
    }
}
