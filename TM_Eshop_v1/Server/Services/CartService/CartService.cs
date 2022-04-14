namespace TM_Eshop_v1.Server.Services.CartService
{
    public class CartService : ICartService
    {
        private readonly DataContext _context;

        public CartService(DataContext context)
        {
            _context = context;
        }
        public async Task<ServiceResponce<List<CartResponce>>> GetProInCart(List<Cart> carts)
        {
            var result = new ServiceResponce<List<CartResponce>>
            {
                Data = new List<CartResponce>()
            };

            foreach (var cart in carts)
            {
                var product = await _context.Products.Where(p => p.ProId == cart.ProId).FirstOrDefaultAsync();

                if(product == null) { continue; }

                var cartPro = new CartResponce
                {
                    ProId = product.ProId,
                    Name = product.Name,
                    Price = product.Price
                };
                result.Data.Add(cartPro);
            }
            return result;
        }
    }
}
