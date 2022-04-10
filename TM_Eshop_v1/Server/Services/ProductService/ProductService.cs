namespace TM_Eshop_v1.Server.Services.ProductService
{
    public class ProductService : ProductServiceInterface
    {
        private readonly DataContext _context;

        public ProductService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetAll()
        {
            var products = await _context.Products.ToListAsync();

            return products;
        }
    }
}
