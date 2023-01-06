using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigServiceDomain.Core.Utilities
{
    public class Suscriber
    {
        private static ConnectionMultiplexer connection = ConnectionMultiplexer.Connect("localhost:6379");
        private const string Channel = "providus-channel";
        public T Suscribe<T>()
        {
            var pubsub = connection.GetSubscriber();
            var model = default(T);
            pubsub.Subscribe(Channel, (channel, message) => model = JsonConvert.DeserializeObject<T>(message));
            return model;
        }
    }
}
