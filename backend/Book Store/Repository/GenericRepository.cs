using Book_Store.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Book_Store.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T: class
    {
        private readonly BookStoreContext context;

        public GenericRepository(BookStoreContext _context)
        {
            context = _context;
        }

        public IEnumerable<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public T GetByID(int id)
        {
            return context.Set<T>().Find(id);
        }

        public void Delete(int id)
        {
            T entity = GetById(id);

            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }

        public void Edit(T entity, int id)
        {
            context.Set<T>().Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }

        public void Insert(T New)
        {
            context.Set<T>().Add(New);
            context.SaveChanges();
        }

        //public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        //{
        //    return context.Set<T>().Where(expression).ToList();
        //}
    }
}
