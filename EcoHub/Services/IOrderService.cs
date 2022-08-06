using EcoHub.Constants;
using EcoHub.Models;

namespace EcoHub.Services
{
    public interface IOrderService
    {
        public Task<string> PlaceOrder(Order order);
        public Task<OrderStatus> GetOrderStatus(string orderNumber);
        public Task<Order> GetOrder(string orderNumber);
        public Task<string> UpdateOrderStatus(string orderNumber, OrderStatus orderStatus);

        public Task<List<Order>> GetAllOrders();
    }
}
