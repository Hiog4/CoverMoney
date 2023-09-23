using Volo.Abp.Domain.Entities;

namespace CoverMoney.Debits
{
    public class Debit : Entity<int>
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public int NumPrestacoes { get; set; }
    }
}
