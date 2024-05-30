using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Dados { 
    public class ContaPagar
    {
        public int id { get; set; }
        public decimal valor { get; set; }
        public DateTime dataCadastro {get; set;}
        public DateTime dataVencimento { get; set; }
        public DateTime dataPagamento { get; set; }
        public MeioPagamento meioPagamento { get; set; }
        public EstadoPagamento situacao { get; set; }
        public Conta conta { get; set; }


    }
}
