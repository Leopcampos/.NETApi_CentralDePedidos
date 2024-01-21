using CentralDePedidos.Domain.Models.Enums;

namespace CentralDePedidos.Domain.Models;

public class Pedido
{
    public Guid? Id { get; set; }
    public DateTime? DataHora { get; set; }
    public decimal? Valor { get; set; }
    public List<Produto>? Produtos { get; set; }
    public StatusPedido? Status { get; set; }
    public Guid? ProtocoloPagamento { get; set; }

    public Guid? ClienteId { get; set; }
    public Cliente? Cliente { get; set; }

    public Guid? CobrancaId { get; set; }
    public Cobranca? Cobranca { get; set; }
}