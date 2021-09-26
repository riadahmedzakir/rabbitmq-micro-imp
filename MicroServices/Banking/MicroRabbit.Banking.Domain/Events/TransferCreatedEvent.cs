using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Domain.Events
{
    public class TransferCreatedEvent : Event
    {
        public string From { get; private set; }
        public string To { get; private set; }
        public decimal Ammount { get; private set; }

        public TransferCreatedEvent(string from, string to, decimal ammount)
        {
            From = from;
            To = to;
            Ammount = ammount;
        }
    }
}
