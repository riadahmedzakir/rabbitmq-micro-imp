using MicroRabbit.Entities;
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
        public BankingDbContext()
        {
            MongoClient client = new MongoClient("mongodb://localhost:27017");
            IMongoDatabase database = client.GetDatabase("BankingDB");

            Account = database.GetCollection<Account>("Account");
        }
        public IMongoCollection<Account> Account { get; set; }
    }
}
