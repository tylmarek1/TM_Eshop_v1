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
    }
}
