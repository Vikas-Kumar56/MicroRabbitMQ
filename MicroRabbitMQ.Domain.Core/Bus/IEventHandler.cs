using System;
using System.Threading.Tasks;
using MicroRabbitMQ.Domain.Core.Events;

namespace MicroRabbitMQ.Domain.Core.Bus
{
    public interface IEventHandler<in TEvent> 
        where TEvent : Event
    {
        Task Handle(TEvent @event);
    }

    
}
