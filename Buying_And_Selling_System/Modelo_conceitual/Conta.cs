using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Dados
{
    public class Conta
    {

        public int id { get; set; }
        public string descricao { get; set; }
        public TipoConta tipo { get; set; }
        public bool status { get; set; }
        public Categoria categoria { get; set; }
    }
}
