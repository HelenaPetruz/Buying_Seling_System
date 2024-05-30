using Dados;
using Modelo_conceitual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ItemVendaService
    {
        private readonly ItemVendaRepository itemVendaRepository;

        public ItemVendaService()
        {
            itemVendaRepository = new ItemVendaRepository();
        }

        public void CadastrarItemVenda(int quantidade, decimal preco, decimal desconto, Venda venda, Produto produto)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var itemVenda = new ItemVenda
            {
                quantidade = quantidade,
                preco = preco,
                desconto = desconto,
                venda = venda,
                produto = produto
            };

            itemVendaRepository.Adicionar(itemVenda);

        }

        public void CadastrarVenda(ItemVenda itemVenda)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            itemVendaRepository.Adicionar(itemVenda);


        }

        public IEnumerable<ItemVenda> ObterTodos()
        {
            return itemVendaRepository.ObterTodos();

        }
        public List<ItemVenda> getAll()
        {
            return itemVendaRepository.ObterTodos().ToList<ItemVenda>();
        }

        public IList<ItemVenda> getItensPorVendaId(int id)
        {
            return itemVendaRepository.getItemsVendaPorVendaId(id);
        }


    }
}

