using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Modelo_conceitual
{
    public class ItemCompra
    {
        public int quantidade {  get; set; }
        public decimal preco { get; set; }

        public Produto produto { get; set; }

        public Compra compra { get; set; }
    }
}
