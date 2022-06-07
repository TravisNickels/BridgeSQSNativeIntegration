using System.Threading.Tasks;
using NativeIntegration.MsmqEndpoint;
using NServiceBus;
using NServiceBus.Logging;

public class SomeNativeMessageHandler : IHandleMessages<SomeNativeMessage>
{
    static ILog log = LogManager.GetLogger<SomeNativeMessageHandler>();

    public async Task Handle(SomeNativeMessage eventMessage, IMessageHandlerContext context)
    {
        //var nativeMessage = context.Extensions.Get<Message>();
        //var nativeAttributeFound = nativeMessage.MessageAttributes.TryGetValue("SomeRandomKey", out var randomAttributeKey);

        //log.Info($"Received {nameof(SomeNativeMessage)} with message {eventMessage.ThisIsTheMessage}.");

        //if (nativeAttributeFound)
        //{
        //    log.Info($"Found attribute 'SomeRandomKey' with value '{randomAttributeKey.StringValue}'");
        //}

        //if (context.ReplyToAddress != null)
        //{
        //    log.Info($"Sending reply to '{context.ReplyToAddress}'");

        //    await context.Reply(new SomeReply());
        //}
        await Task.CompletedTask;
    }
}

