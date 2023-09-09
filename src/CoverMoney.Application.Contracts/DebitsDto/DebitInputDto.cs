using System;
using System.Collections.Generic;
using System.Text;

namespace CoverMoney.DebitsDto
{
    public class DebitInputDto
    {
        public string Nome {  get; set; }
        public double Valor { get; set; }
        public int NumPrestacoes { get; set; }

        public DebitInputDto(string nome, double valor, int numPrestacoes)
        {
            Nome = nome;
            Valor = valor;
            NumPrestacoes = numPrestacoes;
        }
    }    
}
