using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Entities
{
    public class TransferLog
    {
        [BsonId]
        public string ItemId { get; set; }
        public string TransferSource { get; set; }
        public string TransferTarget { get; set; }
        public decimal Ammount { get; set; }
    }
}
