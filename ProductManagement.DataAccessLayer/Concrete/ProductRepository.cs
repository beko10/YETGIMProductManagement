using ProductManagement.DataAccessLayer.Abstract;
using ProductManagement.DataAccessLayer.Context;
using ProductManagement.EntityLayer.Concrete;

namespace ProductManagement.DataAccessLayer.Concrete;

public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    public ProductRepository(AppDbContext context) : base(context)
    {
    }
}
