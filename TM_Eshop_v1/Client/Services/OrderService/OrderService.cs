namespace TM_Eshop_v1.Client.Services.OrderService
{
    public class OrderService : IOrderService
    {
        private readonly HttpClient _http;

        public OrderService(HttpClient http)
        {
            _http = http;
        }
        public List<Order> Orders { get; set; } = new List<Order>();
        public List<Buyer> Buyers { get; set; } = new List<Buyer>();

        public async Task CreateOrder(Order order)
        {
            var result = await _http.PostAsJsonAsync("api/order/postorders", order);
            var responce = await result.Content.ReadFromJsonAsync<List<Order>>();
            Orders = responce;
        }
        public async Task GetOrders()
        {
            var result = await _http.GetFromJsonAsync<List<Order>>("api/order/order");
            if (result != null)
                Orders = result;
        }

        public async Task GetBuyers()
        {
            var result = await _http.GetFromJsonAsync<List<Buyer>>("api/order/buyer");
            if (result != null)
                Buyers = result;
        }
    }
}
