using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Negocio
{
    public class CaixaService
    {
        private readonly CaixaRepository caixaRepository;

        public CaixaService()
        {
            caixaRepository = new CaixaRepository();
        }

        public void CadastrarCaixa(int id, string nome)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var caixa = new Caixa
            {
                id = id,
                nome = nome,
            };

            caixaRepository.Adicionar(caixa);

        }

        public void CadastrarCaixa(Caixa caixa)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            caixaRepository.Adicionar(caixa);

        }

        public IEnumerable<Caixa> ObterTodos()
        {
            return caixaRepository.ObterTodos();
        }
        public List<Caixa> getAll()
        {
            return caixaRepository.ObterTodos().ToList<Caixa>();
        }
        public Caixa FindById(int id)
        {
            foreach (Caixa c in caixaRepository.getAll())
            {
                if (c.id == id) return c;
            }
            return null;
        }

    }
}
