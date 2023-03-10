using System.Linq.Expressions;

namespace Book_Store.Repository
{
    public interface IGenericRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        //IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        void Insert(T entity);
        void Edit(T entity, int id);
        void Delete(int id);
    }
}
