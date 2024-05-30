using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Negocio
{
    public class ClienteService
    {
        private readonly ClienteRepository _repository;

        public ClienteService()
        {
            _repository = new ClienteRepository();
        }

        public void CadastrarCliente(int id, TipoPessoa tipoPessoa, string cpf_cnpj, string razaoSocial, DateTime DataNascimento, string nome,string rua, int numero, string bairro, string cidade, string complemento, string cep, string telefone,string email, string celular, string limite)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var cliente = new Cliente
            {
                Id = id,
                tipoPessoa = tipoPessoa,
                cpf_cnpj = cpf_cnpj,
                razaoSocial = razaoSocial,
                DataNascimento = DataNascimento,
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
                limite = limite
            };

            _repository.Adicionar(cliente);

        }

        public void CadastrarCliente(Cliente cliente)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            _repository.Adicionar(cliente);

        }

        public IEnumerable<Cliente> ObterTodos()
        {
            return _repository.ObterTodos();
        }
        public List<Cliente> getAll()
        {
            return _repository.ObterTodos().ToList<Cliente>();
        }

        public Cliente FindById(int id)
        {
            foreach (Cliente c in _repository.getAll())
            {
                if (c.Id == id) return c;
            }
            return null;
        }

    }
}
