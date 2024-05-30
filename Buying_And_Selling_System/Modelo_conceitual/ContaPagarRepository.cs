using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Dados
{
    public class ContaPagarRepository
    {
        private static List<ContaPagar> listaContaPagar = new List<ContaPagar>();

        public void Adicionar(ContaPagar pagar)
        {
            // Aqui você poderia inserir o cliente em um banco de dados
            // Para simplificar, estamos apenas adicionando a uma lista em memória
            listaContaPagar.Add(pagar);
        }

        public IEnumerable<ContaPagar> ObterTodos()
        {
            return listaContaPagar;
        }
    }
}