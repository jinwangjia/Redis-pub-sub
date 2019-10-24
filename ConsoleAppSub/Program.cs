using StackExchange.Redis;
using System;

namespace ConsoleAppSub
{
    class Program
    {
        static void Main(string[] args)
        {
            var redis = ConnectionMultiplexer.Connect("localhost:6379");
            //var db = redis.GetDatabase();
            var sub = redis.GetSubscriber();
            sub.Subscribe("Channel1", (channel, message) =>
            {
                Console.WriteLine($"Channel1{channel.ToString()} 订阅收到消息:{message.ToString()}");
            });
            Console.ReadLine();
        }
    }
}
