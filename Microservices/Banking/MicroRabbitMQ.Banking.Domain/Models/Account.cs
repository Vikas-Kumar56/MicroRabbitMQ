using System;
namespace MicroRabbitMQ.Banking.Domain.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string AccountType { get; set; }
        public int AcountBalance { get; set; }
    }
}
