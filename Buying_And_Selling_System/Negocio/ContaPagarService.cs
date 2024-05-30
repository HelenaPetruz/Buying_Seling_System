using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Negocio
{
    internal class ContaPagarService
    {
        private readonly ContaPagarRepository contaPagarRepository;

        public ContaPagarService()
        {
            contaPagarRepository = new ContaPagarRepository();
        }

        public void CadastrarConta(int Id, decimal valor, DateTime dataCadastro, DateTime dataVencimento, DateTime dataPagamento, MeioPagamento meioPagamento, EstadoPagamento situacao, Conta conta)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var contaPagar = new ContaPagar
            {
                id = Id,
                valor = valor,
                dataCadastro = dataCadastro,
                dataVencimento = dataVencimento,
                dataPagamento = dataPagamento,
                meioPagamento = meioPagamento,
                situacao = situacao,
                conta=conta,
            };

            contaPagarRepository.Adicionar(contaPagar);

        }

        public void CadastrarConta(ContaPagar contaPagar)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            contaPagarRepository.Adicionar(contaPagar);

        }

        public IEnumerable<ContaPagar> ObterTodos()
        {
            return contaPagarRepository.ObterTodos();
        }
        public List<ContaPagar> getAll()
        {
            return contaPagarRepository.ObterTodos().ToList<ContaPagar>();
        }

    }
}
