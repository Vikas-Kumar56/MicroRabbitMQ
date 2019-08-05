using System;
using System.Threading.Tasks;
using MicroRabbitMQ.Domain.Core.Events;
using MicroRabbitMQ.Domain.Core.Commands;

namespace MicroRabbitMQ.Domain.Core.Bus
{
    public interface IEventBus
    {
        Task SendCommand<T>(T command) where T : Command;

        void Publish<T>(T @event) where T : Event;

        void Subscribe<T, TH>()
               where T : Event
               where TH : IEventHandler<T>;
    }
}
