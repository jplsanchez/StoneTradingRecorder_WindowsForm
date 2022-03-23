using LA.Economy.Entities;
using LA.Economy.Interfaces.Helpers;
using LA.Economy.Interfaces.Repositories;

namespace LA.Economy.Helpers
{
    public class DataRecorder : IDataRecorder
    {
        private readonly ITransactionRepository _transactionRepository;

        public DataRecorder(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        public async Task RecordSellAsync(string type, string value, string date)
        {
            if (!int.TryParse(value, out int valueFormated)) throw new Exception("Preço não está no formato int");
            if (!DateTime.TryParse(date, out DateTime dateFormated)) throw new Exception("Data não está no formato correto");

            TransactionInfo data = new()
            {
                Id = Guid.NewGuid(),
                Type = type,
                Price = valueFormated,
                Date = dateFormated
            };
            await _transactionRepository.InsertTransactionAsync(data);
        }
    }
}