using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MicroRabbitMQ.Banking.Domain.Commands;
using MicroRabbitMQ.Banking.Domain.Events;
using MicroRabbitMQ.Domain.Core.Bus;

namespace MicroRabbitMQ.Banking.Domain.CommandHandlers
{
    public class TransferCommandHandler : IRequestHandler<CreateTransferComamnd, bool>
    {
        private readonly IEventBus eventBus;

        public TransferCommandHandler(IEventBus eventBus)
        {
            this.eventBus = eventBus;
        }

        public Task<bool> Handle(CreateTransferComamnd request, CancellationToken cancellationToken)
        {
            // publish event to rabbitMQ bus
            eventBus.Publish(new TransferCreatedEvent(request.From, request.To, request.Amount));
            return Task.FromResult(true);
        }
    }
}