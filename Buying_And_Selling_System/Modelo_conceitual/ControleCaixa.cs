using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Dados
{
    public class ControleCaixa
    {
        public int id { get; set; }
        public decimal valor { get; set; }
        public DateTime data {  get; set; } 
        public Caixa caixa { get; set; } 

    }
}
