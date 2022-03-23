using System;

namespace LA.Economy.Domain.Entities
{
    public class TransactionInfo
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
    }
}