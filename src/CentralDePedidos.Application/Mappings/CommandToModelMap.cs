using AutoMapper;
using CentralDePedidos.Application.Commands;
using CentralDePedidos.Domain.Models;

namespace CentralDePedidos.Application.Mappings;

public class CommandToModelMap : Profile
{
    public CommandToModelMap()
    {
        CreateMap<PedidoCreateCommand, Pedido>()
            .AfterMap((command, model) =>
            {
                model.Id = Guid.NewGuid();
                model.DataHora = DateTime.Now;
                model.Cobranca.Id = Guid.NewGuid();
                model.Cliente.Id = Guid.NewGuid();
                model.Produtos.ForEach(p => p.Id = Guid.NewGuid());
            });
    }
}