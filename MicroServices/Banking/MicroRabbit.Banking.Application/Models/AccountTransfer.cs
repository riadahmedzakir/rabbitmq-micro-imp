using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Application.Models
{
    public class AccountTransfer
    {
        public string AccountSource { get; set; }
        public string AccountTarget { get; set; }
        public decimal TransferAmount { get; set; }
    }
}
