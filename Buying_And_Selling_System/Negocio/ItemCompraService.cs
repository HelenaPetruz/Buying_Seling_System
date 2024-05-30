using Modelo_conceitual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Negocio
{
    public class ItemCompraService
    {
        private readonly ItemCompraRepository itemCompraRepository;

        public ItemCompraService()
        {
            itemCompraRepository = new ItemCompraRepository();
        }

        public void CadastrarItemCompra(int quantidade, decimal preco, Produto produto, Compra compra)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var itemCompra = new ItemCompra
            {
                quantidade = quantidade,
                preco = preco,
                produto = produto,
                compra = compra,
            };

            itemCompraRepository.Adicionar(itemCompra);

        }

        public void CadastrarCompra(ItemCompra itemCompra)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            itemCompraRepository.Adicionar(itemCompra);

        }

        public IEnumerable<ItemCompra> ObterTodos()
        {
            return itemCompraRepository.ObterTodos();
        }
        public List<ItemCompra> getAll()
        {
            return itemCompraRepository.ObterTodos().ToList<ItemCompra>();


        }

    }
}

