using System;
using System.Threading.Tasks;
using MicroRabbitMQ.Domain.Core.Bus;
using MicroRabbitMQ.Transfer.Domain.Events;
using MicroRabbitMQ.Transfer.Domain.Models;

namespace MicroRabbitMQ.Transfer.Domain.EventHandler
{
    public class TransferEventHandler : IEventHandler<TransferCreatedEvent>
    {
        public TransferEventHandler()
        {
        }

        public Task Handle(TransferCreatedEvent @event)
        {
            var log = new TransferLog();
            log.Amount = @event.Amount;
            log.FromAccount = @event.From;
            log.ToAccount = @event.To;

            System.Console.WriteLine("************ " + log.Amount);
            return Task.CompletedTask;
        }
    }
}
