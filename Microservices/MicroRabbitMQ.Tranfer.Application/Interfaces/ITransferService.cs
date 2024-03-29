﻿using System;
using System.Collections.Generic;
using MicroRabbitMQ.Transfer.Domain.Models;

namespace MicroRabbitMQ.Transfer.Application.Interfaces
{
    public interface ITransferService
    {
        IEnumerable<TransferLog> GetTransferLogs();
    }
}
