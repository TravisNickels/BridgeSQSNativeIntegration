using NServiceBus;

namespace NativeIntegration.bridge
{
    public class SomeNativeMessage : IMessage
    {
        public string ThisIsTheMessage { get; set; }
    }
}
