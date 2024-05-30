using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Dados;
using Negocio;

namespace Apresentacao
{
    public partial class frmCliente : Form
    {
        private readonly ClienteService _clienteService;
        private List<Cliente> lstCliente = new List<Cliente>();
        public frmCliente()
        {
            InitializeComponent();
            _clienteService = new ClienteService();

            dgCliente.Columns.Add("Id", "ID");
            dgCliente.Columns.Add("Nome", "NOME");
            dgCliente.Columns.Add("tipoPesso", "TIPO PESSOA");
            dgCliente.Columns.Add("email", "EMAIL");

            lstCliente = _clienteService.getAll();

            geraAleatorios();
        }

        private void geraAleatorios()
        {
            for (int n = 1; n <= 10; n++)
            {
                Cliente c = new Cliente();
                c.Id = n;
                c.Nome = "Cliente numero " + n.ToString();
                c.Email = "cl" + n.ToString() + "@exemplo.com.br";
                c.tipoPessoa = (n % 2) == 0 ? TipoPessoa.PESSOA_FISICA : TipoPessoa.PESSOA_JURIDICA;
                _clienteService.CadastrarCliente(c);
            }
        }

        private void frmCliente_Load(object sender, System.EventArgs e)
        {
            radioPessoaFisica.Text = TipoPessoa.PESSOA_FISICA.ToString();
            radioPessoaJuridica.Text = TipoPessoa.PESSOA_JURIDICA.ToString();

            // NOVO ====================
            dgCliente.ColumnCount = 4;
            dgCliente.AutoGenerateColumns = false;
            dgCliente.Columns[0].Width = 20;
            dgCliente.Columns[0].HeaderText = "ID";
            dgCliente.Columns[0].DataPropertyName = "Id";
            //dgCliente.Columns[0].Visible = false;
            dgCliente.Columns[1].Width = 275;
            dgCliente.Columns[1].HeaderText = "NOME";
            dgCliente.Columns[1].DataPropertyName = "Nome";
            dgCliente.Columns[2].Width = 300;
            dgCliente.Columns[2].HeaderText = "EMAIL";
            dgCliente.Columns[2].DataPropertyName = "email";
            dgCliente.Columns[3].Width = 100;
            dgCliente.Columns[3].HeaderText = "TIPO";
            dgCliente.Columns[3].DataPropertyName = "tipoPessoa";

            dgCliente.AllowUserToAddRows = false;
            dgCliente.AllowUserToDeleteRows = false;
            dgCliente.MultiSelect = false;
            dgCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            atualizaListaCliente();

        }

        private void atualizaListaCliente()
        {
            dgCliente.DataSource = _clienteService.getAll();
            dgCliente.Refresh();

        }

        private void btnAdicionar_Click(object sender, System.EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            TipoPessoa tp = radioPessoaFisica.Checked ? TipoPessoa.PESSOA_FISICA : TipoPessoa.PESSOA_JURIDICA;
            string cpf_cnpj = txtCpf_cnpj.Text;
            string razaoSocial = txtRazaoSocial.Text;
            DateTime DataNascimento = Convert.ToDateTime(txtDataDeNascimento.Text);
            string Nome = txtNome.Text;
            string rua = txtRua.Text;
            int numero = int.Parse(txtNumero.Text);
            string bairro = txtBairro.Text;
            string cidade = txtCidade.Text;
            string complemento = txtComplemento.Text;
            string cep = txtCep.Text;
            string telefone = txtTelefone.Text;
            string Email = txtEmail.Text;
            string celular = txtCelular.Text;
            string limite = txtLimite.Text;

           

            _clienteService.CadastrarCliente(id, tp,cpf_cnpj, razaoSocial, DataNascimento,Nome, rua,numero,bairro,cidade,complemento,cep,telefone,Email,celular,limite);


            atualizaListaCliente();
        }

        private void dgCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgCliente_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {



        }

        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
