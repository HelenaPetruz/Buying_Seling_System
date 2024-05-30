using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Negocio
{
    public class ProdutoService
    {
            private readonly ProdutoRepository _produtoRepository;

            public ProdutoService()
            {
                _produtoRepository = new ProdutoRepository();
            }

            public void CadastrarProduto(int Id, string Nome, decimal Preco, Fornecedor fornecedor)
            {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var produto = new Produto
            {
                id = Id,
                nome = Nome,
                preco = Preco,
                fornecedor = fornecedor,
                };

                _produtoRepository.Adicionar(produto);

            }

            public void CadastrarProduto(Produto produto)
            {
                // Insira as validações e regras de negócio aqui
                // Por exemplo, verificar se o email já está cadastrado

                _produtoRepository.Adicionar(produto);

            }

            public IEnumerable<Produto> ObterTodos()
            {
                return _produtoRepository.ObterTodos();
            }
            public List<Produto> getAll()
            {
                return _produtoRepository.ObterTodos().ToList<Produto>();
            }

        public Produto FindById(int id)
        {
            foreach(Produto p in _produtoRepository.getAll())
            {
                if (p.id == id) return p;
            }
            return null;
        }

    }
    }

