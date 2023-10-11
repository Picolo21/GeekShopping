using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Models.Context.v1;

public class SqlServerContext : DbContext
{
    public SqlServerContext(DbContextOptions<SqlServerContext> options) : base(options) { }

    public DbSet<Product> Products { get; set; }
}
