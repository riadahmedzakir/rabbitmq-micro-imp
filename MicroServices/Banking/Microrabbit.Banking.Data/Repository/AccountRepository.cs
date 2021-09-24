using Microrabbit.Banking.Data.Context;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microrabbit.Banking.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly IBankingDbContext _context;
        public AccountRepository(IBankingDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public IEnumerable<Account> GetAccounts()
        {
            List<Account> accounts = _context.Account.Find(p => true).ToList();
            return accounts;
        }
    }
}
