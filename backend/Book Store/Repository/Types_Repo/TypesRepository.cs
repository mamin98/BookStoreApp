using Book_Store.Models;
using Microsoft.EntityFrameworkCore;

namespace Book_Store.Repository.Types_Repo
{
    public class TypesRepository : ITypesRepository
    {
        private readonly BookStoreContext context;

        public TypesRepository(BookStoreContext _context)
        {
            context = _context;
        }

       
        // All Types
        public List<Types> GetAll()
        {
            return context.Types.ToList();
        }

        // Type by Id
        public Types GetById(int id)
        {
            return context.Types.AsNoTracking().FirstOrDefault(t => t.Id == id);
        }

        // Add new Type
        public void Insert(Types type)
        {
            context.Types.Add(type);
            context.SaveChanges();
        }

        // update Type details
        public void Edit(Types type, int id)
        {
            Types ExistingType = GetById(id);

            ExistingType = type;
            context.Update(ExistingType);

            context.SaveChanges();
        }


        // Delete Type
        public void Delete(int id)
        {
            Types type = GetById(id);
            context.Types.Remove(type);

            context.SaveChanges();
        }
    }
}
