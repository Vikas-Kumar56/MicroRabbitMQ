using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MicroRabbitMQ.Transfer.Data.Context;
using MicroRabbitMQ.Transfer.Domain.Interfaces;
using MicroRabbitMQ.Transfer.Domain.Models;

namespace MicroRabbitMQ.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private readonly TransferDBContext transferDBContext;

        public TransferRepository(TransferDBContext transferDBContext)
        {
            this.transferDBContext = transferDBContext;
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return transferDBContext.Logs;
        }

        public async Task InsertTransferLog(TransferLog transferLog)
        {
            await transferDBContext.Logs.AddAsync(transferLog);

            await transferDBContext.SaveChangesAsync();

             
        }
    }
}
