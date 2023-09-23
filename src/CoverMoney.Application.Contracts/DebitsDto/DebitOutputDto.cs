namespace CoverMoney.DebitsDto
{
    public class DebitOutputDto
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public int NumPrestacoes { get; set; }
        public int Id { get; set; }

        public DebitOutputDto(string nome, double valor, int numPrestacoes, int id)
        {
            Nome = nome;
            Valor = valor;
            NumPrestacoes = numPrestacoes;
            Id = id;
        }
    }
}
