using System.Threading.Tasks;
using NativeIntegration.Receiver;
using NServiceBus;
using NServiceBus.Logging;

public class SomeNativeMessageHandler : IHandleMessages<SomeNativeMessage>
{
    static ILog log = LogManager.GetLogger<SomeNativeMessageHandler>();

    public Task Handle(SomeNativeMessage eventMessage, IMessageHandlerContext context)
    {
        //var nativeMessage = context.Extensions.Get<Message>();
        //var nativeAttributeFound = nativeMessage.MessageAttributes.TryGetValue("SomeRandomKey", out var randomAttributeKey);
        log.Info("Some native message received");

        return Task.CompletedTask;
    }
}

