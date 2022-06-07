using System.Threading.Tasks;
using NServiceBus;
using NServiceBus.Logging;

public class SomeNativeMessageHandler : IHandleMessages<SomeNativeMessage>
{
    static ILog log = LogManager.GetLogger<SomeNativeMessageHandler>();

    public Task Handle(SomeNativeMessage eventMessage, IMessageHandlerContext context)
    {        
        log.Info($"Received {nameof(SomeNativeMessage)} with message {eventMessage.ThisIsTheMessage}.");

        return Task.CompletedTask;
    }
}

