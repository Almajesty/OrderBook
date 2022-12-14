using OrderBook.Application.Common.Persistance;
using OrderBook.Persistence.Context;

namespace OrderBook.Persistence.Repositories;

public class EFGenericRepository<T> : IGenericRepository<T> where T : class
{
    ApplicationContext _context;
    public Microsoft.EntityFrameworkCore.DbSet<T> _dbSet;

    public EFGenericRepository(ApplicationContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }

    public IEnumerable<T> GetAll()
    {
        return _dbSet.ToList();
    }

    public IEnumerable<T> Where(System.Func<T, bool> predicate)
    {
        return _dbSet.Where(predicate);
    }

    public void Create(T item)
    {
        _dbSet.Add(item);
    }

    public void Delete(int id)
    {
        _dbSet.Remove(_dbSet.Find(id));
    }

    public T GetItemById(int id)
    {
        return _dbSet.Find(id);
    }

    public void Update(T item)
    {
        _dbSet.Update(item);
    }

    public void Delete(T item)
    {
        _dbSet.Remove(item);
    }
}
