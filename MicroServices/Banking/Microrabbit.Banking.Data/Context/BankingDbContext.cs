using MicroRabbit.Banking.Domain.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microrabbit.Banking.Data.Context
{
    public class BankingDbContext : IBankingDbContext
    {
        public BankingDbContext(string TenantId)
        {
            MongoClient client = new MongoClient("localhost:27017");
            IMongoDatabase database = client.GetDatabase("BankingDb");

            Account = database.GetCollection<Account>("Account");
        }
        public IMongoCollection<Account> Account { get; set; }
    }
}
