using LA.Economy.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA.Economy.Interfaces.Repositories
{
    public interface ITransactionRepository
    {
        Task InsertTransactionAsync(TransactionInfo data);
    }
}