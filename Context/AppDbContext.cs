using Microsoft.EntityFrameworkCore;
using MinhaPrimeiraAPIDotNet.Models;

namespace MinhaPrimeiraAPIDotNet.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {
        }

        public DbSet<Categoria>? Categorias { get; set; }
        public DbSet<Produto>? Produtos { get; set; }
    }
}
