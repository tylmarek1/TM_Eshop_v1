namespace TM_Eshop_v1.Client.Services.OrderService
{
    public interface IOrderService
    {
        List<Order> Orders { get; set; }
        List<Buyer> Buyers { get; set; }
        Task GetOrders();
        Task GetBuyers();
        Task CreateOrder(Order order);
    }
}
