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

namespace MicroRabbitMQ.Infrastucture.Ioc
{
    public static class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<IEventBus, RabbitMQBus>();

            // Application services
            services.AddTransient<IAccountService, AccountService>();

            // Domain banking commands
            services.AddTransient<IRequestHandler<CreateTransferComamnd, bool>, TransferCommandHandler>();

            //Data
            services.AddTransient<IAccountRepository, AccountRepository>();

            //entity framework dbcontext, Banking
            services.AddTransient<BankingDBContext>();


        }
    }
}
