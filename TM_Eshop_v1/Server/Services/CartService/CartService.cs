namespace TM_Eshop_v1.Server.Services.CartService
{
    public class CartService : ICartService
    {
        private readonly DataContext _context;

        public CartService(DataContext context)
        {
            _context = context;
        }
        public async Task<ServiceResponce<List<CartResponce>>> GetCartProducts(List<CartItem> cartItems)
        {
            var result = new ServiceResponce<List<CartResponce>> { Data = new List<CartResponce>()};

            foreach (var item in cartItems)
            {
                var product = await _context.Products.Where(p => p.ProId == item.ProductId).FirstOrDefaultAsync();
                if (product == null) { continue; }
                var cartProduct = new CartResponce
                {
                    ProductId = product.ProId,
                    Name = product.Name,
                    Price = product.Price,
                };
                result.Data.Add(cartProduct);
            }
            return result;
        }
    }
}
