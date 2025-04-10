using ProductManagement.EntityLayer.Abstract;

namespace ProductManagement.EntityLayer.Concrete;

public sealed class Product:BaseEntity
{
    public string Name { get; set; } 
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }

    public Product()
    {
        Name = string.Empty;
        Description = string.Empty;
    }
}
