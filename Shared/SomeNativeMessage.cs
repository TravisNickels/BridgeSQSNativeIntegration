using NServiceBus;

public class SomeNativeMessage : IMessage
{
    public string ThisIsTheMessage { get; set; }
}
