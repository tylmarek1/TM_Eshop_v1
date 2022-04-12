namespace TM_Eshop_v1.Server.Services.ProductService
{
    public class ProductService : IProductServiceInterface
    {
        private readonly DataContext _context;

        public ProductService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponce<Product>> GetProductAsync(int proId)
        {
            var responce = new ServiceResponce<Product>();
            var product = await _context.Products.FindAsync(proId);
            if (product == null)
            {
                responce.Success = false;
                responce.Message = "Wrong path or maybe error lol.";
            }
            else
            {
                responce.Data = product;
            }
            return responce;
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
                .Where(parametr => parametr.Kategorie.CatUrl.ToLower()
                .Equals(catUrl.ToLower()))
                .ToListAsync()
            };
            return responce;
        }

        public async Task<ServiceResponce<List<Product>>> Search(string searchString)
        {
            var responce = new ServiceResponce<List<Product>>
            {
                Data = await _context.Products
                    .Where(parametr => parametr.Name.ToLower()
                    .Contains(searchString.ToLower()))
                    .ToListAsync()
            };
            return responce;
        }
    }
}
