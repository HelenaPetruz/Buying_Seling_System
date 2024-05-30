using Dados;
using Modelo_conceitual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class FornecedorService
    {
        private readonly FornecedorRepository _FornecedorRepository;

        public FornecedorService()
        {
            _FornecedorRepository = new FornecedorRepository();
        }

        public void CadastrarFornecedor(int id, TipoPessoa tipoPessoa, string cpf_cnpj, string razaoSocial, string nome, string rua, int numero, string bairro, string cidade, string complemento, string cep, string telefone, string email, string celular)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var fornecedor = new Fornecedor
            {
                Id = id,
                tipoPessoa = tipoPessoa,
                cpf_cnpj = cpf_cnpj,
                razaoSocial = razaoSocial,

                Nome = nome,
                rua = rua,
                numero = numero,

                bairro = bairro,
                cidade = cidade,
                complemento = complemento,
                cep = cep,
                telefone = telefone,
                Email = email,
                celular = celular,
               
            };

            _FornecedorRepository.Adicionar(fornecedor);

        }

        public void CadastrarFornecedor(Fornecedor fornecedor)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            _FornecedorRepository.Adicionar(fornecedor);

        }

        public IEnumerable<Fornecedor> ObterTodos()
        {
            return _FornecedorRepository.ObterTodos();
        }
        public List<Fornecedor> getAll()
        {
            return _FornecedorRepository.ObterTodos().ToList<Fornecedor>();
        }

        public Fornecedor FindById(int id)
        {
            foreach (Fornecedor c in _FornecedorRepository.getAll())
            {
                if (c.Id == id) return c;
            }
            return null;
        }

    }
}

