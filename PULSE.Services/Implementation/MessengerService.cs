using Newtonsoft.Json;
using PULSE.Model;
using PULSE.Services.Interfaces;
using RabbitMQ.Client;
using System.Text;

namespace PULSE.Services.Implementation
{
    public class MessengerService : IMessengerService
    {
        public void sendEmail(Email email)
        {
            var hostname = Environment.GetEnvironmentVariable("RABBITMQ_HOST") ?? "localhost";
            var username = Environment.GetEnvironmentVariable("RABBITMQ_USER") ?? "guest";
            var password = Environment.GetEnvironmentVariable("RABBITMQ_PASS") ?? "guest";

            var factory = new ConnectionFactory { HostName = hostname, UserName = username, Password = password };
            using var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();

            channel.QueueDeclare(queue: "email.create",
                                 durable: false,
                                 exclusive: false,
                                 autoDelete: false,
                                 arguments: null);

            var body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(email));

            channel.BasicPublish(exchange: string.Empty,
                                 routingKey: "email.create",
                                 basicProperties: null,
                                 body: body);
        }
    }
}
