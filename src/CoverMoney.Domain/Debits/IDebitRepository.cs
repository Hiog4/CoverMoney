using Volo.Abp.Domain.Repositories;

namespace CoverMoney.Debits
{
    public interface IDebitRepository : IRepository<Debit, int>
    {
    }
}
