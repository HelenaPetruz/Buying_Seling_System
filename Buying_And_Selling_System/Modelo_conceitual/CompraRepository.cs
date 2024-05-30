using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class CompraRepository
    {
        private static List<Compra> listaCompra = new List<Compra>();

        public void Adicionar(Compra compra)
        {
            // Aqui você poderia inserir o cliente em um banco de dados
            // Para simplificar, estamos apenas adicionando a uma lista em memória
            listaCompra.Add(compra);
        }

        public IEnumerable<Compra> ObterTodos()
        {
            return listaCompra;
        }
        public IList<Compra> getAll()
        {
            return listaCompra;
        }
    }
}
