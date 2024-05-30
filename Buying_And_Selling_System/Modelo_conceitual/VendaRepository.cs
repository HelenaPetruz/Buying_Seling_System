using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class VendaRepository
    {
        private static List<Venda> listaVenda = new List<Venda>();

        public void Adicionar(Venda venda)
        {
            // Aqui você poderia inserir o cliente em um banco de dados
            // Para simplificar, estamos apenas adicionando a uma lista em memória
            listaVenda.Add(venda);
        }

        public IEnumerable<Venda> ObterTodos()
        {
            return listaVenda;
        }

        public IList<Venda> getAll()
        {
            return listaVenda;
        }
    }
}
