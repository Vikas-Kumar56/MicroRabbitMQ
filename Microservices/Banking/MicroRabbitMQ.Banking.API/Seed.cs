using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroRabbitMQ.Banking.Data.Context;
using MicroRabbitMQ.Banking.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroRabbitMQ.Banking.API
{
    public class Seed
    {
        private BankingDBContext bankingDBContext;

        public Seed(BankingDBContext bankingDBContext)
        {
            this.bankingDBContext = bankingDBContext;
        }

        public async Task SeedAsync()
        {
            using (bankingDBContext)
            {
               
                bankingDBContext.Database.Migrate();
                bankingDBContext.Database.EnsureCreated();
                
                System.Console.WriteLine("Enter seed *****");
                System.Console.WriteLine(bankingDBContext);
                if (!bankingDBContext.Accounts.Any())
                {
                    bankingDBContext.Accounts.AddRange(
                     GetAccounts()
                   );
                    await bankingDBContext.SaveChangesAsync();
                }

            }
        }

        static IEnumerable<Account> GetAccounts()
        {
            return new List<Account>()
            {
                new Account()
                {
                    AccountType = "Saving",
                    
                    AcountBalance = 12
                },
                new Account()
                {
                    AccountType = "Current",
                    
                    AcountBalance = 34
                }
            };
        }
    }
}
