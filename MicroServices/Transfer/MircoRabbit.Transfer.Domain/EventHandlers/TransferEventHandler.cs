using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Entities;
using MicroRabbit.Transfer.Domain.Events;
using MicroRabbit.Transfer.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MircoRabbit.Transfer.Domain.EventHandlers
{
    public class TransferEventHandler : IEventHandler<TransferCreatedEvent>
    {
        private readonly ITransferRepository _transferRepository;
        public TransferEventHandler(ITransferRepository transferRepository)
        {
            _transferRepository = transferRepository;
        }

        public Task Handle(TransferCreatedEvent @event)
        {
            _transferRepository.CreateTransferLog(new TransferLog()
            {
                ItemId = Guid.NewGuid().ToString(),
                TransferSource = @event.From,
                TransferTarget = @event.To,
                Ammount = @event.Ammount
            });

            return Task.CompletedTask;
        }
    }
}
