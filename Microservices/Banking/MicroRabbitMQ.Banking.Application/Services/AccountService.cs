using System;
using System.Collections.Generic;
using MicroRabbitMQ.Banking.Application.Interfaces;
using MicroRabbitMQ.Banking.Application.Models;
using MicroRabbitMQ.Banking.Domain.Commands;
using MicroRabbitMQ.Banking.Domain.Interfaces;
using MicroRabbitMQ.Banking.Domain.Models;
using MicroRabbitMQ.Domain.Core.Bus;

namespace MicroRabbitMQ.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository accountRepository;

        private readonly IEventBus eventBus;

        public AccountService(IAccountRepository accountRepository,
               IEventBus eventBus)
        {
            this.accountRepository = accountRepository;
            this.eventBus = eventBus;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return accountRepository.GetAccounts();
        }

        public void Transfer(AccountTransfer accountTransfer)
        {
            var createTransferCommand = new CreateTransferComamnd(
                accountTransfer.FromAccount,
                accountTransfer.ToAccount,
                accountTransfer.Amount
            );

            eventBus.SendCommand(createTransferCommand);
        }
    }
}
