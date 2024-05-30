using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Dados
{
    public class ContaRepository
    {
        private static List<Conta> listaConta = new List<Conta>();

        public void Adicionar(Conta conta)
        {
            // Aqui você poderia inserir o cliente em um banco de dados
            // Para simplificar, estamos apenas adicionando a uma lista em memória
            listaConta.Add(conta);
        }

        public IEnumerable<Conta> ObterTodos()
        {
            return listaConta;
        }
        public IList<Conta> getAll()
        {
            return listaConta;
        }
    }
}
