using LA.Economy.Entities;
using LA.Economy.Infra.Utility;
using LA.Economy.Interfaces.Repositories;
using Microsoft.Extensions.Logging;

namespace LA.Economy.Infra.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private const string _filePath = @"C:\Users\jpaul\source\repos\SandBox\LA.Economy\LA.Economy\Infra\Data\TransactionFile.csv";

        private readonly ILogger _logger;

        public TransactionRepository(ILogger<TransactionRepository> logger)
        {
            _logger = logger;
        }

        public async Task InsertTransactionAsync(TransactionInfo data)
        {
            try
            {
                await CommaSeparatedValuesHelper.InsertIntoFileAsync(data, _filePath);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
        }
    }
}