using Microsoft.AspNetCore.Components;

namespace TM_Eshop_v1.Client.Services.OrderService
{
    public class OrderService : IOrderService
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;

        public OrderService(HttpClient http, NavigationManager navigationManager)
        {
            _http = http;
            _navigationManager = navigationManager;
        }
        public List<Order> Orders { get; set; } = new List<Order>();

        public async Task CreateOrder(Order order)
        {
            var result = await _http.PostAsJsonAsync("api/order/createorder", order);
            var responce = await result.Content.ReadFromJsonAsync<List<Order>>();
            Orders = responce;
            _navigationManager.NavigateTo("");
        }

        public async Task GetOrder()
        {
            var result = await _http.GetFromJsonAsync<List<Order>>("api/order");
            if (result != null)
                Orders = result;
        }
    }
}
