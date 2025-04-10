using ProductManagement.EntityLayer.Concrete;

namespace ProductManagement.BusinessLayer.Abstract;

public interface IProductService
{
    List<Product> GetAll();
    Product GetById(string id);
    void Add(Product product);
    void Update(Product product);
    void Delete(string id);
}
