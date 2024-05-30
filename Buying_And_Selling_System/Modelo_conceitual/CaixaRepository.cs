using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Dados
{
    public class CaixaRepository
    {
        private static List<Caixa> listaCaixa = new List<Caixa>();

        public void Adicionar(Caixa caixa)
        {
            // Aqui você poderia inserir o cliente em um banco de dados
            // Para simplificar, estamos apenas adicionando a uma lista em memória
            listaCaixa.Add(caixa);
        }

        public IEnumerable<Caixa> ObterTodos()
        {
            return listaCaixa;
        }
        public IList<Caixa> getAll()
        {
            return listaCaixa;
        }
    }
}
