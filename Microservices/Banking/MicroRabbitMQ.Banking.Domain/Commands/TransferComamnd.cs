
using MediatR;
using MicroRabbitMQ.Domain.Core.Commands;

namespace MicroRabbitMQ.Banking.Domain.Commands
{
    public class TransferComamnd : Command
    {
        public int To { get; protected set; }
        public int From { get; protected set; }
        public int Amount { get; protected set; }
    }
}