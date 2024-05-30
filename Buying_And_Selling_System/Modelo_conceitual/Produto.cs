using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;


namespace Dados
{
     public class Produto
    {
        public int id{ get; set; }

    public string nome { get; set; }
public decimal preco { get; set; }

        public Fornecedor fornecedor { get; set; }



    }
}
