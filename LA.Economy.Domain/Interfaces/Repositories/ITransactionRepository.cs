using LA.Economy.Domain.Entities;
using System.Threading.Tasks;

namespace LA.Economy.Domain.Interfaces.Repositories
{
    public interface ITransactionRepository
    {
        Task InsertTransactionAsync(TransactionInfo data);
    }
}