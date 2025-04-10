using ProductManagement.EntityLayer.Abstract;

namespace ProductManagement.DataAccessLayer.Abstract;

public interface IGenericRepository<TEntity> where TEntity : BaseEntity
{
    TEntity GetById(string id);
    List<TEntity> GetAll();
    void Add(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);
}
