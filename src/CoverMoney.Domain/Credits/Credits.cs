using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace CoverMoney.Credits
{
    public class Credits : Entity<int>
    {
        public double Valor { get; set; }
        public string Origin { get; set; }

    }
}
