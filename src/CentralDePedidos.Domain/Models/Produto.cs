namespace CentralDePedidos.Domain.Models;

public class Produto
{
    public Guid? Id { get; set; }
    public string? Nome { get; set; }
    public decimal? Preco { get; set; }
    public int? Quantidade { get; set; }
    public List<Pedido>? Pedidos { get; set; }
}