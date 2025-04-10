using Microsoft.EntityFrameworkCore;
using ProductManagement.DataAccessLayer.Abstract;
using ProductManagement.DataAccessLayer.Context;
using ProductManagement.EntityLayer.Abstract;

namespace ProductManagement.DataAccessLayer.Concrete;

public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
{
    private readonly AppDbContext _context;
    private DbSet<TEntity> _dbSet;

    public GenericRepository(AppDbContext context)
    {
        _context = context;
        //_dbSet = context.Set<TEntity>();
    }

    public void Add(TEntity entity)
    {
        _context.Set<TEntity>().Add(entity);
        _context.SaveChanges();
    }

    public void Delete(TEntity entity)
    {
        _context.Set<TEntity>().Remove(entity);
        _context.SaveChanges(); 
    }

    public List<TEntity> GetAll()
    {
        return _context.Set<TEntity>().ToList();
    }

    public TEntity GetById(string id)
    {
        return _context.Set<TEntity>().Find(id);
    }

    public void Update(TEntity entity)
    {
        _context.Set<TEntity>().Update(entity); 
        _context.SaveChanges(); 
    }
}

