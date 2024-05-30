using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Dados
{
        public class CategoriaRepository
        {
            private static List<Categoria> listaCategoria = new List<Categoria>();

            public void Adicionar(Categoria categoria)
            {
                // Aqui você poderia inserir o cliente em um banco de dados
                // Para simplificar, estamos apenas adicionando a uma lista em memória
                listaCategoria.Add(categoria);
            }

            public IEnumerable<Categoria> ObterTodos()
            {
                return listaCategoria;
            }
        public IList<Categoria> getAll()
        {
            return listaCategoria;
        }
    }
}
