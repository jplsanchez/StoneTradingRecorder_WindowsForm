using LA.Economy.Domain.Entities;
using System.Threading.Tasks;

namespace LA.Economy.Domain.Interfaces.Helpers
{
    public interface IDataRecorder
    {
        Task<TransactionInfo> RecordSellAsync(string type, string value, string quantity, string date);
    }
}