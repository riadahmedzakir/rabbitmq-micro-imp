using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Domain.Commands
{
    public class CreateTransferCommand : TransferCommand
    {
        public CreateTransferCommand(string from, string to, decimal ammount)
        {
            From = from;
            To = to;
            Ammount = ammount;
        }
    }
}
