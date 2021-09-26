using MicroRabbit.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microrabbit.Transfer.Data.Context
{
    public interface ITransferDbContext
    {
        IMongoCollection<TransferLog> TransferLog { get; set; }
    }
}
