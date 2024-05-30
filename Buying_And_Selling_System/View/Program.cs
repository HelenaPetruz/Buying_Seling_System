using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;
using Negocio;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteService cliServ = new ClienteService();
            FornecedorService fornServ = new FornecedorService();
            CompraService compServ = new CompraService();
            ProdutoService prodServ = new ProdutoService();
            VendaService vendaServ = new VendaService();
            ItemVendaService itemVendaServ = new ItemVendaService();
            ContaService contServ = new ContaService();
            CategoriaService catServ = new CategoriaService();
            ContaReceberService contRecServ = new ContaReceberService();
            ControleCaixaService conCaixaServ = new ControleCaixaService();
            CaixaService caixaServ = new CaixaService();

            //Insere alguns clientes
            cliServ.CadastrarCliente(1, TipoPessoa.PESSOA_FISICA,"123456789", "José Alberto Matioli",DateTime.Now,"José","Rua feliz",2,"Bairro Alegre","Porto Alegre", "22","3333333","9999999999", " matioli@unicamp.br","88888888888","30000");
            Console.WriteLine("CLIENTES");
            foreach (Cliente cliente in cliServ.getAll())
            {
                Console.WriteLine("{0} - {1} - {2} - {3}",
                    cliente.Id, cliente.Nome, cliente.tipoPessoa, cliente.Email);
            }

            fornServ.CadastrarFornecedor(1, TipoPessoa.PESSOA_FISICA, "112233445566", "Loja do Turco", "Zé", "Rua feliz", 7, "Bairro Alegre", "Porto Alegre", "77", "333333333333", "19999888", "ze@gmail.com", "19333366666");
            Console.WriteLine("\nFORNECEDOR");
            foreach (Fornecedor fornecedor in fornServ.getAll())
            {
                Console.WriteLine("{0} - {1} - {2} - {3}",
                   fornecedor.Id, fornecedor.tipoPessoa, fornecedor.cpf_cnpj, fornecedor.razaoSocial);
            }

            compServ.CadastrarCompra(1, DateTime.Now, "", 0, 25.50, fornServ.FindById(1));
            compServ.CadastrarCompra(2, DateTime.Now, "", 25,1270, fornServ.FindById(1));
            Console.WriteLine("\nCOMPRA");
            foreach (Compra compra in compServ.getAll())
            {
                Console.WriteLine("{0} - {1} - {2} - {3}",
                compra.id, compra.instante, compra.desconto, compra.valor_total);
            }


            //Insere alguns produtos
            prodServ.CadastrarProduto(2, "Monitor LG Flatron", 1245,fornServ.FindById(1));
            prodServ.CadastrarProduto(1, "Papel Sulfite", 25.50M,fornServ.FindById(1));
            

            Console.WriteLine("\nPRODUTOS");
            foreach (Produto produto in prodServ.getAll())
            {
                Console.WriteLine("{0} - {1} - {2}",
                    produto.id, produto.nome, produto.preco);
            }

            //Insere algumas vendas
            Console.WriteLine("\nVENDAS");
            vendaServ.CadastrarVenda(1, cliServ.FindById(1), DateTime.Now, "", 0, 1225.00);
            vendaServ.CadastrarVenda(3, cliServ.FindById(1), DateTime.Now, "", 0, 50.00);
            //Itens desta venda
            itemVendaServ.CadastrarItemVenda(1, 1245,45, vendaServ.FindById(1),prodServ.FindById(2));
            itemVendaServ.CadastrarItemVenda(1, 25, 0, vendaServ.FindById(1), prodServ.FindById(1));
            itemVendaServ.CadastrarItemVenda(2, 50, 0, vendaServ.FindById(3), prodServ.FindById(1));

            foreach (Venda v in vendaServ.getAll())
            {
                Console.WriteLine("{0} - {1} - {2:0.00}",
                    v.instante.Date, v.Cliente.Nome, v.valor_total);
                Console.WriteLine("------- ITENS ------------");
                foreach (ItemVenda itemVenda in itemVendaServ.getItensPorVendaId(v.id))
                { 
                    Console.WriteLine("\t{0} - {1} - {2}",
                    itemVenda.produto.nome, itemVenda.quantidade,
                    itemVenda.preco);
                }
                Console.WriteLine(Environment.NewLine);
            }

            contServ.CadastrarConta(1, "Venda Direta", TipoConta.CONTA_RECEBER, true, catServ.FindById(1));
            contServ.CadastrarConta(2, "Venda Corporativa", TipoConta.CONTA_RECEBER, true, catServ.FindById(1));

            Console.WriteLine("\nCONTAS");
            foreach (Conta conta in contServ.getAll())
            {
                Console.WriteLine("{0} - {1} - {2} - {3} - {4}",
                    conta.id, conta.descricao, conta.tipo, conta.status, conta.categoria);
            }

            DateTime data1 = new DateTime(2024, 04, 11, 16, 06, 00);
            DateTime data2 = new DateTime(2024, 04, 13, 23, 59, 00);
            contRecServ.CadastrarConta(1, 50M, data1, data2, null, null, MeioPagamento.BOLETO, EstadoPagamento.PENDENTE, contServ.FindById(1));
            DateTime data3 = new DateTime(2024, 04, 11, 12, 35, 00);
            DateTime data4 = new DateTime(2024, 04, 12, 12, 35, 00);
            contRecServ.CadastrarConta(2, 1225.00M, data3, data3, data4, 1225.00M, MeioPagamento.PIX, EstadoPagamento.QUITADO, contServ.FindById(2));
            Console.WriteLine("\nCONTAS RECEBER");
            foreach (ContaReceber contaReceber in contRecServ.getAll())
            {
                Console.WriteLine("{0} - {1} - {2} - {3} - {4} - {5} - {6} - {7} - {8}",
                    contaReceber.id, contaReceber.valor, contaReceber.dataCadastro, contaReceber.dataVencimento, contaReceber.dataRecebimento, contaReceber.valorRecebido, contaReceber.meioPgamento, contaReceber.situacao, contaReceber.conta);
            }

            catServ.CadastrarCategoria(1, "Receita");
            Console.WriteLine("\nCATEGORIAS");
            foreach (Categoria categoria in catServ.getAll())
            {
                Console.WriteLine("{0} - {1}",
                    categoria.id, categoria.nome);
            }

            conCaixaServ.CadastrarControleCaixa(1, 1225, data3, caixaServ.FindById(1));
            conCaixaServ.CadastrarControleCaixa(2, 50, data1, caixaServ.FindById(2));
            Console.WriteLine("\nCONTROLE CAIXA");
            foreach (ControleCaixa caixa in conCaixaServ.getAll())
            {
                Console.WriteLine("{0} - {1} - {2}",
                    caixa.id, caixa.valor, caixa.data, caixa.caixa);
            }


            Console.ReadKey();
        }
    }
}
