using LA.Economy.Domain.Entities;
using LA.Economy.Domain.Interfaces.Helpers;
using LA.Economy.Domain.Interfaces.Repositories;
using System;
using System.Threading.Tasks;

namespace LA.Economy.Domain.Helpers
{
    public class DataRecorder : IDataRecorder
    {
        private readonly ITransactionRepository _transactionRepository;

        public DataRecorder(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        public async Task<TransactionInfo> RecordSellAsync(string type, string value, string quantity, string date)
        {
            if (!int.TryParse(value, out int valueFormated)) throw new Exception("Preço não está no formato int");
            if (!int.TryParse(quantity, out int quantityFormated)) throw new Exception("Quantidade não está no formato int");
            if (!DateTime.TryParse(date, out DateTime dateFormated)) throw new Exception("Data não está no formato correto");

            TransactionInfo data = new()
            {
                Id = Guid.NewGuid(),
                Type = type,
                Price = valueFormated,
                Quantity = quantityFormated,
                Date = dateFormated
            };
            await _transactionRepository.InsertTransactionAsync(data);
            return data;
        }
    }
}