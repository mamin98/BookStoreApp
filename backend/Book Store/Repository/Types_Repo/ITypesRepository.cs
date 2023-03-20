using Book_Store.DTOs.TypeDTOs;
using Book_Store.Models;

namespace Book_Store.Repository.Types_Repo
{
    public interface ITypesRepository
    {
        void Delete(int id);
        void Edit(Types type, int id);
        List<Types> GetAll();
        Types GetById(int id);
        TypeDto GetByIdInclude(int id);
        void Insert(Types book);
    }
}