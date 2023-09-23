using CoverMoney.DebitsDto;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace CoverMoney.Debits
{
    public class DebitAppService : ApplicationService
    {
        public readonly IDebitRepository _debitRepository;

        public DebitAppService(IDebitRepository debitRepository)
        {
            _debitRepository = debitRepository;
        }

        [HttpPost("/débito")]
        public async Task<DebitOutputDto> CreateDebit(DebitInputDto debitInput)
        {
            var debit = ObjectMapper.Map<DebitInputDto, Debit>(debitInput);
            await _debitRepository.InsertAsync(debit);
            return ObjectMapper.Map<Debit, DebitOutputDto>(debit);
        }

    }
}
