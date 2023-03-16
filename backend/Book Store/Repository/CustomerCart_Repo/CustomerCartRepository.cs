using Book_Store.DTOs.BookDTOs;
using Book_Store.Models;

namespace Book_Store.Repository.CustomerCart_Repo;

public class CustomerCartRepository : ICustomerCartRepository
{
    private readonly BookStoreContext _context;

    public CustomerCartRepository(BookStoreContext context)
    {
        _context = context;
    }


    public async Task<(bool success, string message)> PurchaseOrderAsync(CartDto customerCart)
    {
        if (customerCart == null)
            throw new ArgumentNullException(nameof(customerCart));

        // fetch user record from database
        var mockedUserId = 1;

        // TODO:: to replaced by real customer from user manager
        var MockedCustomer = _context.Customers.FirstOrDefault(c => c.ID == mockedUserId);

        // fetch productIds needed for product prices & handling product quantity in stock
        var productIds = customerCart.CartItems.Select(ci => ci.Id).ToList();

        var itemPrice = GetProductPricesAsync(productIds);
        // update cartItemsDto however many times were added by the user
        var cartItemsDto = customerCart.CartItems.Select(item => new CartItemDto
        {
            Id = item.Id,
            Price = itemPrice[item.Id],
            Quantity = item.Quantity
        }).ToList();
        customerCart.CartItems = cartItemsDto;


        // create customer Order (Cart) updating the cart items ready for the database schema
        var cart = new Order
        {
            CustomerId = mockedUserId,
            OrderDate = DateTime.UtcNow,
            Books = cartItemsDto.Select(ci => new OrderItem
            {
                BookId = ci.Id,
                Price = ci.Price,
                Quantity = ci.Quantity,
            }).ToList(),
            TotalPrice = cartItemsDto.Sum(c => c.TotalPrice)
        };


        // update products quantity
        var quantitiyUpdated = await UpdateProductsQuantityAsync(productIds, customerCart);

        if (quantitiyUpdated.success)
        {
            //update database with customer Order
            _context.Orders.Add(cart);
            _context.SaveChangesAsync();
        }
        return quantitiyUpdated;
    }



    private async Task<(bool success, string message)> UpdateProductsQuantityAsync(IEnumerable<int> productIds, CartDto customerCart)
    {
        var products = _context.Books.Where(p => productIds.Contains(p.Id)).ToList();

        var productQuantity = 0;
        var orderSuceeded = true;

        foreach (var product in products)
        {
            var cartItem = customerCart.CartItems.FirstOrDefault(ci => ci.Id == product.Id);

            // return false when there is not sufficient producst or cart item doesnot exist
            if (cartItem is null)
            {
                orderSuceeded = false;
                return (false, "Error occured to cartItem. Try again later");
            }

            if (cartItem.Quantity > product.QuantityInStock || cartItem.Quantity < 0)
            {
                orderSuceeded = false;
                return (false, $"Insufficient or invalid quantity for product: {product.Title}. Try again later");
            }

            if (cartItem.Quantity is 0)
            {
                orderSuceeded = false;
                return (false, $"Please specify quantity for product: {product.Title}. Try again later");
            }


            productQuantity += cartItem.Quantity;

            // decrement product quantity records according per customer items
            product.QuantityInStock -= cartItem.Quantity;
        }

        // Undo product quantity records update when order failed
        if (!orderSuceeded)
        {
            foreach (var product in products)
            {
                product.QuantityInStock += productQuantity;
            }
        }

        await _context.SaveChangesAsync();
        return (true, "Your Order has confirmed successfully");
    }

    private Dictionary<int, decimal> GetProductPricesAsync(IEnumerable<int> productIds)
    {
        var productPrices = _context.Books
            .Where(p => productIds.Contains(p.Id))
            .Select(p => new { p.Id, p.Price })
            .ToDictionary(p => p.Id, p => p.Price);
        return productPrices;
    }
}


