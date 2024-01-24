using examdmaws.Data;
using examdmaws.Models;
using Microsoft.AspNetCore.Mvc;

namespace examdmaws.Controllers
{
    // Controllers/OrderController.cs
    [ApiController]
    [Route("api/orders")]
    public class OrderController : ControllerBase
    {
        private readonly OrderDbContext _dbContext;

        public OrderController(OrderDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public IActionResult PlaceOrder(Order order)
        {
            _dbContext.Orders.Add(order);
            _dbContext.SaveChanges();
            return Ok("Order placed successfully");
        }

        [HttpPut("{orderId}")]
        public IActionResult EditOrder(int orderId, Order updatedOrder)
        {
            var existingOrder = _dbContext.Orders.Find(orderId);

            if (existingOrder == null)
            {
                return NotFound("Order not found");
            }

            existingOrder.OrderDelivery = updatedOrder.OrderDelivery;
            existingOrder.OrderAddress = updatedOrder.OrderAddress;

            _dbContext.SaveChanges();
            return Ok("Order updated successfully");
        }
    }

}
