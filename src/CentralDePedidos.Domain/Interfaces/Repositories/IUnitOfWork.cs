namespace CentralDePedidos.Domain.Interfaces.Repositories;

public interface IUnitOfWork : IDisposable
{
    IClienteRepository ClienteRepository { get; }
    ICobrancaRepository CobrancaRepository { get; }
    IPedidoRepository PedidoRepository { get; }
    IProdutoRepository ProdutoRepository { get; }

    void SaveChanges();
}