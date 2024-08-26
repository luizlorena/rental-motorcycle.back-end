using Microsoft.Extensions.Configuration;
using RabbitMQ.Client;
using Rental.MotorCycle.Domain.Interface.IEventBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Rental.MotorCycle.Application.ServiceApp
{
    public class EventBusServiceApp : IEventBus
    {
        private readonly IConfiguration _configuration;

        public EventBusServiceApp(IConfiguration config)
        {
            _configuration = config;
        }

        public void SendProductMessage<T>(T message)
        {
            var factory = new ConnectionFactory
            {
                //HostName = "localhost",
                Uri = new Uri(_configuration["RabbitMQ"])
            };
            
            var connection = factory.CreateConnection();

            using var channel = connection.CreateModel();

            channel.QueueDeclare("motorcycle-crud", exclusive: false);
         
            var json = JsonSerializer.Serialize(message);
            var body = Encoding.UTF8.GetBytes(json);

            channel.BasicPublish(exchange: "", routingKey: "motorcycle-crud", body: body);
        }
    }
}
