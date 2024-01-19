using CentralDePedidos.Application.Commands;

namespace CentralDePedidos.IntegrationTests.Models;

/// <summary>
/// Modelo de dados para deserializar a resposta da API
/// após o processamento de um pedido (POST)
/// </summary>
public class PedidoResultModel
{
    public string? Message { get; set; }
    public PedidoCreateCommand? Pedido { get; set; }
}