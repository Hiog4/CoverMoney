using Volo.Abp.Domain.Entities;

namespace CoverMoney.Debits
{
    public class Debit : Entity<int>
    {
        public string Name { get; set; }
        public double Valor { get; set; }
        public int ParcelNumb { get; set; }
        public ParcelType ParcelType { get; set; }

    }
}
