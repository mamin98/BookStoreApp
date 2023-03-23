using Book_Store.DTOs.BookDTOs;
using Book_Store.DTOs.CustomerCartDTOs;
using Book_Store.Repository.CustomerCart_Repo;

using Microsoft.AspNetCore.Mvc;

namespace Book_Store.Controllers;

[Route("api/books/purchases")]
[ApiController]
public class PurchaseOrderController : ControllerBase
{
    private readonly ICustomerCartRepository _customerCartRepository;

    public PurchaseOrderController(ICustomerCartRepository customerCartRepository)
    {
        _customerCartRepository = customerCartRepository;
    }

    [HttpPost]
    public async Task<ActionResult<CartDto>> PurchaseOrderAsync([FromBody] CartDto customerCart)
    {
        if (customerCart is null)
        {
            return BadRequest("Invalid request..");
        }

        var purchasedItems = await _customerCartRepository.PurchaseOrderAsync(customerCart);

        return purchasedItems.success
            ? Ok(new PurchasedItemResponseDto
            {
                Success = true,
                Message = purchasedItems.message
            })
            : BadRequest(new PurchasedItemResponseDto
            {
                Success = false,
                Message = purchasedItems.message,
            });
    }

}
