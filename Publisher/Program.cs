using StackExchange.Redis;
using System;

namespace Publisher
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = ConnectionMultiplexer.Connect("localhost");
            var pubsub = client.GetSubscriber();

            pubsub.Publish("id1", "HelloWorld");
            
        }
    }
}
