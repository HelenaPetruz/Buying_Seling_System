using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Dados
{
    public class ContaReceberRepository
    {
        private static List<ContaReceber> listaContaReceber = new List<ContaReceber>();

        public void Adicionar(ContaReceber conta)
        {
            // Aqui você poderia inserir o cliente em um banco de dados
            // Para simplificar, estamos apenas adicionando a uma lista em memória
            listaContaReceber.Add(conta);
        }

        public IEnumerable<ContaReceber> ObterTodos()
        {
            return listaContaReceber;
        }
    }
}

