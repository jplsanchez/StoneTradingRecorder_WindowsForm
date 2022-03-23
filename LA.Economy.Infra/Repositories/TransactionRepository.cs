using LA.Economy.Domain.Entities;
using LA.Economy.Domain.Interfaces.Repositories;
using LA.Economy.Infra.Utility;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace LA.Economy.Infra.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        public const string _filePath = @"C:\Users\jpaul\source\repos\SandBox\LA.Economy\LA.Economy.Infra\Data\TransactionFile.csv";

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