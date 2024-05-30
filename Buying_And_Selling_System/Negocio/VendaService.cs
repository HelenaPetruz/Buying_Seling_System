using Modelo_conceitual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Negocio
{
    public class VendaService
    {
        private readonly VendaRepository vendaRepository;

        public VendaService()
        {
            vendaRepository = new VendaRepository();
        }

        public void CadastrarVenda(int id, Cliente cliente, DateTime intante, string descricao, double desconto, double valor_total)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var venda = new Venda
            {
                id = id,
                Cliente = cliente,
                instante = intante,
                descricao = descricao,
                desconto = desconto,
                valor_total = valor_total

            };

            vendaRepository.Adicionar(venda);

        }

        public void CadastrarVenda(Venda venda)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            vendaRepository.Adicionar(venda);

        }

        public IEnumerable<Venda> ObterTodos()
        {
            return vendaRepository.ObterTodos();
        }
        public List<Venda> getAll()
        {
            return vendaRepository.ObterTodos().ToList<Venda>();
        }

        public Venda FindById(int id)
        {
            foreach (Venda p in vendaRepository.getAll())
            {
                if (p.id == id) return p;
            }
            return null;
        }
    }
}
