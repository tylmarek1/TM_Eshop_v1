namespace TM_Eshop_v1.Server.Data.DataContext
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Product>? Products { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Buyer>? Buyers { get; set; }
        public DbSet<Order>? Orders { get; set; }
    }
}
