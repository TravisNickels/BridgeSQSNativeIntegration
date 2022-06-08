using NServiceBus;

namespace NativeIntegration.Shared
{
    public class SomeNativeMessage : IMessage
    {
        public string ThisIsTheMessage { get; set; }
    }
}

