using CentralDePedidos.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CentralDePedidos.Infra.Data.Contexts;

public class DataContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase(databaseName: "BD_CentralDePedidos");
    }

    public DbSet<Cliente> Cliente { get; set; }
    public DbSet<Cobranca> Cobranca { get; set; }
    public DbSet<Pedido> Pedido { get; set; }
    public DbSet<Produto> Produto { get; set; }
}