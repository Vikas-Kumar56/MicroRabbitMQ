using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MicroRabbitMQ.Transfer.Domain.Models;

namespace MicroRabbitMQ.Transfer.Domain.Interfaces
{
    public interface ITransferRepository
    {
        IEnumerable<TransferLog> GetTransferLogs();

        Task InsertTransferLog(TransferLog transferLog);
    }
}
