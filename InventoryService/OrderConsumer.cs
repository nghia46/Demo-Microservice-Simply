using MassTransit;
using Model;
using Newtonsoft.Json;

namespace InventoryService
{
    public class OrderConsumer : IConsumer<Order>
    {
        public async Task Consume(ConsumeContext<Order> context)
        {
            Order order = context.Message;
            string jsonResponse = JsonConvert.SerializeObject(order);
            await Console.Out.WriteLineAsync(jsonResponse);
            //Impement Logic in the consummer
        }
    }
}
