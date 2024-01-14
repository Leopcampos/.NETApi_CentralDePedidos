using AutoMapper;
using CentralDePedidos.Application.Commands;
using CentralDePedidos.Application.Events;
using CentralDePedidos.Application.Interfaces.Publishers;
using CentralDePedidos.Application.Interfaces.Services;
using CentralDePedidos.Domain.Interfaces.Services;
using CentralDePedidos.Domain.Models;
using Newtonsoft.Json;

namespace CentralDePedidos.Application.Services;

public class PedidoAppService : IPedidoAppService
{
    private readonly IPedidoDomainService? _pedidoDomainService;
    private readonly IEventPublisher _eventPublisher;
    private readonly IMapper? _mapper;

    public PedidoAppService(IPedidoDomainService? pedidoDomainService, IMapper? mapper, IEventPublisher eventPublisher)
    {
        _pedidoDomainService = pedidoDomainService;
        _mapper = mapper;
        _eventPublisher = eventPublisher;
    }

    public async Task Add(PedidoCreateCommand command)
    {
        #region Adicionando o pedido

        var model = _mapper.Map<Pedido>(command);
        _pedidoDomainService.Add(model);

        #endregion

        #region Gerando o evento de pedido realizado

        var @event = new PedidoRealizadoEvent
        {
            Id = Guid.NewGuid(),
            DataHoraCriacao = DateTime.Now,
            DetalhesPedido = JsonConvert.SerializeObject(model)
        };

        await _eventPublisher.Publish(@event);

        #endregion
    }

    public void Dispose()
    {
        _pedidoDomainService.Dispose();
    }
}