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
    public class CompraService
    {
        private readonly CompraRepository compraRepository;

        public CompraService()
        {
           compraRepository = new CompraRepository();
        }

        public void CadastrarCompra(int id, DateTime intante, string descricao, double desconto, double valor_total, Fornecedor fornecedor)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var compra = new Compra
            {
                id = id,
                instante = intante,
                descricao = descricao,
                desconto = desconto,
                valor_total = valor_total,
                fornecedor = fornecedor,

            };

            compraRepository.Adicionar(compra);

        }

        public void CadastrarCompra(Compra compra)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            compraRepository.Adicionar(compra);

        }

        public IEnumerable<Compra> ObterTodos()
        {
            return compraRepository.ObterTodos();
        }
        public List<Compra> getAll()
        {
            return compraRepository.ObterTodos().ToList<Compra>();
        }

        public Compra FindById(int id)
        {
            foreach (Compra c in compraRepository.getAll())
            {
                if (c.id == id) return c;
            }
            return null;
        }
    }
}
