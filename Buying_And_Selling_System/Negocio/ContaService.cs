using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Negocio

{
    public class ContaService
    {
        private readonly ContaRepository contaRepository;

        public ContaService()
        {
            contaRepository = new ContaRepository();
        }

        public void CadastrarConta(int Id, string descricao, TipoConta tipo, bool status, Categoria categoria)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var conta = new Conta
            {
                id = Id,
                descricao = descricao,
                tipo = tipo,
                status = status,
                categoria=categoria,
            };

            contaRepository.Adicionar(conta);

        }

        public void CadastrarConta(Conta conta)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            contaRepository.Adicionar(conta);

        }

        public IEnumerable<Conta> ObterTodos()
        {
            return contaRepository.ObterTodos();
        }
        public List<Conta> getAll()
        {
            return contaRepository.ObterTodos().ToList<Conta>();
        }

        public Conta FindById(int id)
        {
            foreach (Conta c in contaRepository.getAll())
            {
                if (c.id == id) return c;
            }
            return null;
        }

    }
}
