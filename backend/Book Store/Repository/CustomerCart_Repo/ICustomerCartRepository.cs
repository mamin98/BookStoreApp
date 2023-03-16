using Book_Store.DTOs.BookDTOs;

namespace Book_Store.Repository.CustomerCart_Repo;

public interface ICustomerCartRepository
{
    Task<(bool success, string message)> PurchaseOrderAsync(CartDto customerCart);
}