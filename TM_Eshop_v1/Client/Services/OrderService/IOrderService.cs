namespace TM_Eshop_v1.Client.Services.OrderService
{
    public interface IOrderService
    {
        List<Order> Orders { get; set; }
        Task GetOrder();
        Task CreateOrder(Order order);
    }
}
