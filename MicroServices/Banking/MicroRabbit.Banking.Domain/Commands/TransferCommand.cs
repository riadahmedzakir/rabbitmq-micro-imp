using MicroRabbit.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Domain.Commands
{
    public class TransferCommand : Command
    {
        public string From { get; protected set; }
        public string To { get; protected set; }
        public decimal Ammount { get; protected set; }
    }
}
