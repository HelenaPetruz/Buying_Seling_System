using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_conceitual
{
    public class ItemCompraRepository
    {
        private static List<ItemCompra> listaItemCompra = new List<ItemCompra>();

        public void Adicionar(ItemCompra itemCompra)
        {
            // Aqui você poderia inserir o cliente em um banco de dados
            // Para simplificar, estamos apenas adicionando a uma lista em memória
            listaItemCompra.Add(itemCompra);
        }

        public IEnumerable<ItemCompra> ObterTodos()
        {
            return listaItemCompra;
        }
    }
}
