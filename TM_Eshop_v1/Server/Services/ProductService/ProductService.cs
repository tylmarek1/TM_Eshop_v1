namespace TM_Eshop_v1.Server.Services.ProductService
{
    public class ProductService : IProductServiceInterface
    {
        private readonly DataContext _context;

        public ProductService(DataContext context)
        {
            _context = context;
        }
        public async Task<ServiceResponce<List<Product>>> GetProductsAsync()
        {
            var responce = new ServiceResponce<List<Product>> 
            {
                Data = await _context.Products.ToListAsync()
            };
            return responce;
        }

        public async Task<ServiceResponce<List<Product>>> GetProductsByCategory(string catUrl)
        {
            var responce = new ServiceResponce<List<Product>>
            {
                Data = await _context.Products
                .Where(p => p.Kategorie.CatUrl.ToLower()
                .Equals(catUrl.ToLower()))
                .ToListAsync()
            };
            return responce;
        }
    }
}
