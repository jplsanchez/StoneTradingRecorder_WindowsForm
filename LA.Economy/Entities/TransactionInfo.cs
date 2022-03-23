using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA.Economy.Entities
{
    public class TransactionInfo
    {
        public Guid Id { get; set; } 
        public string Type { get; set; }
        public int Price { get; set; }
        public DateTime Date { get; set; }
    }
}
