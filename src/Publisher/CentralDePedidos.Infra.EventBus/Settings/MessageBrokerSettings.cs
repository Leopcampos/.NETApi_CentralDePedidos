namespace CentralDePedidos.Infra.EventBus.Settings;

public class MessageBrokerSettings
{
    public string? ConnectionString { get; set; }
    public string? QueueName { get; set; }
}