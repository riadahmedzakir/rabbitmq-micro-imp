using MicroRabbit.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microrabbit.Transfer.Data.Context
{
    public class TransferDbContext : ITransferDbContext
    {
        public TransferDbContext()
        {
            MongoClient client = new MongoClient("mongodb://localhost:27017");
            IMongoDatabase database = client.GetDatabase("BankingDB");

            TransferLog = database.GetCollection<TransferLog>("TransferLog");
        }
        public IMongoCollection<TransferLog> TransferLog { get; set; }
    }
}
