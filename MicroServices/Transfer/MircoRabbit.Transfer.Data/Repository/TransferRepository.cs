using Microrabbit.Transfer.Data.Context;
using MicroRabbit.Entities;
using MicroRabbit.Transfer.Domain.Interfaces;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microrabbit.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private readonly ITransferDbContext _context;
        public TransferRepository(ITransferDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<Task> CreateTransferLog(TransferLog log)
        {
            await _context.TransferLog.InsertOneAsync(log);
            return Task.CompletedTask;
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            List<TransferLog> transferLogs = _context.TransferLog.Find(p => true).ToList();
            return transferLogs;
        }
    }
}
