using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Negocio
{
    public class ControleCaixaService
    {
        private readonly ControleCaixaRepository controleCaixaRepository;

        public ControleCaixaService()
        {
            controleCaixaRepository = new ControleCaixaRepository();
        }

        public void CadastrarControleCaixa(int id, decimal valor, DateTime data, Caixa caixa)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var controleCaixa = new ControleCaixa
            {
                id = id,
                valor = valor,
                data= data,
                caixa=caixa,
            };

            controleCaixaRepository.Adicionar(controleCaixa);

        }

        public void CadastrarControleCaixa(ControleCaixa controleCaixa)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            controleCaixaRepository.Adicionar(controleCaixa);

        }

        public IEnumerable<ControleCaixa> ObterTodos()
        {
            return controleCaixaRepository.ObterTodos();
        }
        public List<ControleCaixa> getAll()
        {
            return controleCaixaRepository.ObterTodos().ToList<ControleCaixa>();
        }

    }
}