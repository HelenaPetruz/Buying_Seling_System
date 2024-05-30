using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Negocio
{
    public class CategoriaService
    {
        private readonly CategoriaRepository categoriaRepository;

        public CategoriaService()
        {
            categoriaRepository = new CategoriaRepository();
        }

        public void CadastrarCategoria(int id, string nome)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var categoria = new Categoria
            {
                id = id,
                nome=nome,
            };

            categoriaRepository.Adicionar(categoria);

        }

        public void CadastrarCategoria(Categoria categoria)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            categoriaRepository.Adicionar(categoria);

        }

        public IEnumerable<Categoria> ObterTodos()
        {
            return categoriaRepository.ObterTodos();
        }
        public List<Categoria> getAll()
        {
            return categoriaRepository.ObterTodos().ToList<Categoria>();
        }

        public Categoria FindById(int id)
        {
            foreach (Categoria c in categoriaRepository.getAll())
            {
                if (c.id == id) return c;
            }
            return null;
        }

    }
}
