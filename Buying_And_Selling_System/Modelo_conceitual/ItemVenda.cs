using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Dados
{
    public class ItemVenda
    {
        public int quantidade {  get; set; }
        public decimal preco { get; set; }
        public decimal desconto { get; set; }

        public Venda venda { get; set; }

        public Produto produto { get; set; }


    }
}
