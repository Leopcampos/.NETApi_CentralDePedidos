using CentralDePedidos.Domain.Models;
using CentralDePedidos.Infra.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace CentralDePedidos.Infra.Data.Contexts;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ClienteConfiguration());
        modelBuilder.ApplyConfiguration(new CobrancaConfiguration());
        modelBuilder.ApplyConfiguration(new PedidoConfiguration());
        modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
    }

    public DbSet<Cliente> Cliente { get; set; }
    public DbSet<Cobranca> Cobranca { get; set; }
    public DbSet<Pedido> Pedido { get; set; }
    public DbSet<Produto> Produto { get; set; }
}