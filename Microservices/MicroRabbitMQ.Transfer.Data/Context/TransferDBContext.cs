using System;
using MicroRabbitMQ.Transfer.Domain.Models;
using Microsoft.EntityFrameworkCore;


namespace MicroRabbitMQ.Transfer.Data.Context
{
    public class TransferDBContext : DbContext
    {
        public TransferDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<TransferLog> Logs { get; set; }
    }
}
