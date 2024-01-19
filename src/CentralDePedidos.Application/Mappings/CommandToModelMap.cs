using AutoMapper;
using CentralDePedidos.Application.Commands;
using CentralDePedidos.Domain.Models;

namespace CentralDePedidos.Application.Mappings;

public class CommandToModelMap : Profile
{
    public CommandToModelMap()
    {
        CreateMap<ClienteCreateCommand, Cliente>()
            .AfterMap((command, model) =>
            {
                model.Id = Guid.NewGuid();
            });

        CreateMap<CobrancaCreateCommand, Cobranca>()
            .AfterMap((command, model) =>
            {
                model.Id = Guid.NewGuid();
            });

        CreateMap<ProdutoCreateCommand, Produto>()
            .AfterMap((command, model) =>
            {
                model.Id = Guid.NewGuid();
            });

        CreateMap<PedidoCreateCommand, Pedido>()
            .AfterMap((command, model) =>
        {
            model.Id = Guid.NewGuid();
            model.DataHora = DateTime.Now;
        });
    }
}