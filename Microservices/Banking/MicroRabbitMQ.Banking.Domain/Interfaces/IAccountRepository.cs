using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using MicroRabbitMQ.Banking.Domain.Models;

namespace MicroRabbitMQ.Banking.Domain.Interfaces
{
    public interface IAccountRepository
    {
       IEnumerable<Account> GetAccounts();
    }
}
