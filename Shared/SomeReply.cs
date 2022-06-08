using NServiceBus;

public class SomeReply : IMessage
{
    public string ThisIsTheMessage { get; set; }
}
