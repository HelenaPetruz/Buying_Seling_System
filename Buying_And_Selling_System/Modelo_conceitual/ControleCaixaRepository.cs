using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Dados
{
    public class ControleCaixaRepository
    {
        private static List<ControleCaixa> listaControleCaixa = new List<ControleCaixa>();

        public void Adicionar(ControleCaixa controleCaixa)
        {
            // Aqui você poderia inserir o cliente em um banco de dados
            // Para simplificar, estamos apenas adicionando a uma lista em memória
            listaControleCaixa.Add(controleCaixa);
        }

        public IEnumerable<ControleCaixa> ObterTodos()
        {
            return listaControleCaixa;
        }
    }
}