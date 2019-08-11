using System;
using System.Collections.Generic;
using MicroRabbitMQ.Domain.Core.Bus;
using MicroRabbitMQ.Transfer.Application.Interfaces;
using MicroRabbitMQ.Transfer.Domain.Interfaces;
using MicroRabbitMQ.Transfer.Domain.Models;

namespace MicroRabbitMQ.Transfer.Application.Services
{
    public class TransferService : ITransferService
    {
        private readonly ITransferRepository transferRepository;
        private readonly IEventBus eventBus;

        public TransferService(ITransferRepository transferRepository,
            IEventBus eventBus)
        {
            this.transferRepository = transferRepository;
            this.eventBus = eventBus;
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return transferRepository.GetTransferLogs();
        }
    }
}
