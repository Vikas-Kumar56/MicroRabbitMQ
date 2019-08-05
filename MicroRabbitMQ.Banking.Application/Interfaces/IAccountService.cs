﻿using System;
using System.Collections.Generic;
using MicroRabbitMQ.Banking.Domain.Models;

namespace MicroRabbitMQ.Banking.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();
    }
}
