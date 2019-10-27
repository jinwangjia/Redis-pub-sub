using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPub
{
    class Program
    {
        static void Main(string[] args)
        {
            var redis = ConnectionMultiplexer.Connect("localhost:6379");
            var sub = redis.GetSubscriber();
            for(int i =0;i<=10000;i++)
            {
                sub.Publish("Channel1", "dsdsdsds");

            }
        }
    }
}
