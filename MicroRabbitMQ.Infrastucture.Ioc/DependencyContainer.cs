using System;
using MicroRabbitMQ.Domain.Core.Bus;
using MicroRabbitMQ.Infrastructure.Bus;
using Microsoft.Extensions.DependencyInjection;
using MicroRabbitMQ.Banking.Application.Interfaces;
using MicroRabbitMQ.Banking.Application.Services;
using MicroRabbitMQ.Banking.Data.Repository;
using MicroRabbitMQ.Banking.Domain.Interfaces;
using MicroRabbitMQ.Banking.Data.Context;
using MediatR;
using MicroRabbitMQ.Banking.Domain.Commands;
using MicroRabbitMQ.Banking.Domain.CommandHandlers;
using MicroRabbitMQ.Transfer.Application.Interfaces;
using MicroRabbitMQ.Transfer.Application.Services;
using MicroRabbitMQ.Transfer.Data.Repository;
using MicroRabbitMQ.Transfer.Domain.Interfaces;
using MicroRabbitMQ.Transfer.Data.Context;
using MicroRabbitMQ.Banking.Domain.Events;
using MicroRabbitMQ.Transfer.Domain.EventHandler;
using MicroRabbitMQ.Transfer.Domain.Events;

namespace MicroRabbitMQ.Infrastucture.Ioc
{
    public static class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<IEventBus, RabbitMQBus>();

            // Application services
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<ITransferService, TransferService>();

            // event handler with event
            services.AddTransient<IEventHandler<Transfer.Domain.Events.TransferCreatedEvent>, TransferEventHandler>();

            // Domain banking commands
            services.AddTransient<IRequestHandler<CreateTransferComamnd, bool>, TransferCommandHandler>();

            //Data
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<ITransferRepository, TransferRepository>();

            //entity framework dbcontext, Banking
            services.AddTransient<BankingDBContext>();
            services.AddTransient<TransferDBContext>();


        }
    }
}
