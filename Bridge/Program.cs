using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Amazon.S3;
using Amazon.SimpleNotificationService;
using Amazon.SQS;
using NServiceBus;

class Program
{
    static async Task Main(string[] args)
    {
        Console.Title = "Samples.Transport.Bridge.Bridge";

        await Host.CreateDefaultBuilder()
            .UseNServiceBusBridge((ctx, bridgeConfiguration) =>
            {
                var sqsBridgeEndpoint = new BridgeEndpoint("Samples.Sqs.Sender");
                var sqsBridgeTransport = new BridgeTransport(new SqsTransport(CreateSqsClient(), CreateSnsClient()));
                sqsBridgeTransport.AutoCreateQueues = true;
                sqsBridgeTransport.HasEndpoint(sqsBridgeEndpoint);
                bridgeConfiguration.AddTransport(sqsBridgeTransport);

                var msmqBridgeEndpoint = new BridgeEndpoint("Samples.Transport.Bridge.MsmqEndpoint");
                var msmqBridgeTransport = new BridgeTransport(new MsmqTransport());
                msmqBridgeTransport.AutoCreateQueues = true;
                msmqBridgeTransport.HasEndpoint(msmqBridgeEndpoint);
                bridgeConfiguration.AddTransport(msmqBridgeTransport);
            })
            .Build()
            .RunAsync().ConfigureAwait(false);
    }

    public static IAmazonSQS CreateSqsClient()
    {
        return new AmazonSQSClient();
    }

    public static IAmazonSimpleNotificationService CreateSnsClient()
    {
        return new AmazonSimpleNotificationServiceClient();
    }
}
