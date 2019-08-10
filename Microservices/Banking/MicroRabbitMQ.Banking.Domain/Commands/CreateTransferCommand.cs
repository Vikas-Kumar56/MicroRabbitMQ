namespace MicroRabbitMQ.Banking.Domain.Commands
{
    public class CreateTransferComamnd : TransferComamnd
    {
        public CreateTransferComamnd(int from, int to, int amount)
        {
            From = from;
            To = to;
            Amount = amount;
        }
    }
}