using NServiceBus;

namespace NativeIntegration.MsmqEndpoint
{
    public class SomeNativeMessage : IMessage
    {
        public string ThisIsTheMessage { get; set; }
    }
}
