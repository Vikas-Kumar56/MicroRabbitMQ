using MicroRabbitMQ.Domain.Core.Events;

namespace MicroRabbitMQ.Banking.Domain.Events
{
    public class TransferCreatedEvent : Event
    {
        public int From { get; protected set; }
        public int To { get; protected set; }
        public int Amount { get; protected set; }

        public TransferCreatedEvent(int from, int to, int amount)
        {
            From = from;
            To = to;
            Amount = amount;
        }
    }
}