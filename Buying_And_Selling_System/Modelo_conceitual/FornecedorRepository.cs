using Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class FornecedorRepository
    {
        private static List<Fornecedor> listaFornecedor = new List<Fornecedor>();

        public void Adicionar(Fornecedor fornecedor)
        {
            // Aqui você poderia inserir o cliente em um banco de dados
            // Para simplificar, estamos apenas adicionando a uma lista em memória
            listaFornecedor.Add(fornecedor);

        }

        public IEnumerable<Fornecedor> ObterTodos()
        {
            return listaFornecedor;
        }

        public IList<Fornecedor> getAll()
        {
            return listaFornecedor;
        }
    }
}


