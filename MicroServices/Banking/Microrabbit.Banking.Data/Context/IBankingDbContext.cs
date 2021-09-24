using MicroRabbit.Banking.Domain.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microrabbit.Banking.Data.Context
{
    public interface IBankingDbContext
    {
        IMongoCollection<Account> Account { get; set; }
    }
}
