using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Entities
{
    public class Account
    {
        [BsonId]
        public string ItemId { get; set; }
        public string AccountType { get; set; }
        public decimal AccountBalance { get; set; }
    }
}
