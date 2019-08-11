using System;
namespace MicroRabbitMQ.Transfer.Domain.Models
{
    public class TransferLog
    {
        public int Id { get; set; }
        public int ToAccount { get; set; }
        public int FromAccount { get; set; }

        public int Amount { get; set; }

    }
}
