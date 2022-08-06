using EcoHub.Constants;
using EcoHub.Data;
using EcoHub.Helpers;
using EcoHub.Models;
using Microsoft.EntityFrameworkCore;

namespace EcoHub.Services
{

    public class OrderService : IOrderService
    {
        private EcoHubContext db;
        private OrderNumberGenerator _orderNumberGenerator;

        public OrderService(EcoHubContext dbContext, OrderNumberGenerator orderNumberGenerator)
        {
            db = dbContext;
            _orderNumberGenerator = orderNumberGenerator;
        }

        public async Task<Order> GetOrder(string orderNumber)
        {
            return await db.Orders.FindAsync(orderNumber);
        }

        public async Task<List<Order>> GetAllOrders()
        {
            return await db.Orders.ToListAsync();
        }

        public async Task<OrderStatus> GetOrderStatus(string orderNumber)
        {
            Order currentOrder = await db.Orders.FindAsync(orderNumber);
            return (OrderStatus)currentOrder.Status;
        }

        public async Task<string> PlaceOrder(Order order)
        {
            order.OrderNumber = await _orderNumberGenerator.GenerateOrderNumber();
            order.Status = OrderStatus.Created;
            db.Orders.Add(order);
            db.SaveChanges();
            return "Order " + order.OrderNumber + " created with status: " + order.Status;
        }

        public async Task<string> UpdateOrderStatus(string orderNumber, OrderStatus orderStatus)
        {
            Order currentOrder = await db.Orders.FindAsync(orderNumber);
            if (currentOrder != null)
            {
                currentOrder.Status = orderStatus;
                db.SaveChanges();
            }
            return "Order status updated to: " + currentOrder.Status;
        }

        Task<OrderStatus> IOrderService.GetOrderStatus(string orderNumber)
        {
            throw new NotImplementedException();
        }

        Task<Order> IOrderService.GetOrder(string orderNumber)
        {
            throw new NotImplementedException();
        }
    }
}
