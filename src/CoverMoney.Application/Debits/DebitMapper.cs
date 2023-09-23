using CoverMoney.DebitsDto;
using AutoMapper;

namespace CoverMoney.Debits
{
    public class DebitMapper : Profile
    {
        public DebitMapper()
        {
            CreateMap<DebitInputDto, Debit>();
            CreateMap<Debit, DebitOutputDto>();
        } 
    }
}
