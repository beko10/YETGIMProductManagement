using ProductManagement.BusinessLayer.Abstract;
using ProductManagement.DataAccessLayer.Abstract;
using ProductManagement.EntityLayer.Concrete;

namespace ProductManagement.BusinessLayer.Concrete;

public class ProductManager(IProductRepository productRepository) : IProductService
{
    //private readonly IProductRepository _productRepository;

    //public ProductManager(IProductRepository productRepository)
    //{
    //    _productRepository = productRepository;
    //}

    public void Add(Product product)
    {
        //
        productRepository.Add(product);
    }

    public void Delete(string id)
    {
        var deletedProductSearch = productRepository.GetById(id);
        if (deletedProductSearch is not null)
        {
            productRepository.Delete(deletedProductSearch);
        }
    }

    public List<Product> GetAll()
    {
        return productRepository.GetAll();
    }

    public Product GetById(string id)
    {
       return productRepository.GetById(id);
    }

    public void Update(Product product)
    {
        var updatedProductSearch = productRepository.GetById(product.Id);
        if (updatedProductSearch is not null)
        {
            updatedProductSearch.Name = product.Name;
            updatedProductSearch.Price = product.Price;
            updatedProductSearch.Description = product.Description;
            updatedProductSearch.Stock = product.Stock;

            productRepository.Update(updatedProductSearch);
        }
    }
}
