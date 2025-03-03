using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudTesteFinal_Gerenciar_alunos
{
    public partial class FormGerenciarAlunos : Form
    {
        public FormGerenciarAlunos()
        {
            InitializeComponent();
        }

        Conexao conn = new Conexao();
        Alunos  dadosAlunos = new Alunos();

        public void ArmazenarDados()
        {
            dadosAlunos.SetId(int.Parse(txtID.Text));
            dadosAlunos.SetIdade(int.Parse(txtIdade.Text));
            dadosAlunos.SetNotaFinal(double.Parse(txtNotaFinal.Text));
            dadosAlunos.SetCurso(cmbCurso.Text);
            dadosAlunos.SetNome(txtNome.Text);


        }

        public void LimparDados()
        {
            txtNome.Text = "";
            txtID.Text = "";
            txtIdade.Text = "";
            txtNotaFinal.Text = "";
            cmbCurso.Text = "";
        }

        public void ExibirDados()
        {
            dtgAlunos.DataSource = dadosAlunos.ListarAlunos();
        }

        private void FormGerenciarAlunos_Load(object sender, EventArgs e)
        {
            ExibirDados();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtIdade.Text) ||
                string.IsNullOrWhiteSpace(txtNotaFinal.Text) ||
                string.IsNullOrWhiteSpace(cmbCurso.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return false;
            }
            return true;
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            ArmazenarDados();
            dadosAlunos.InserirAluno();

            ExibirDados();
            LimparDados();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {   if (!ValidarCampos()) return;
            dadosAlunos.SetId (int.Parse(txtID.Text));
            ArmazenarDados();
            dadosAlunos.AlterarAluno();

            ExibirDados();
            LimparDados();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {   if (!ValidarCampos()) return;   
            dadosAlunos.SetId(int.Parse(txtID.Text));
            ArmazenarDados();
            dadosAlunos.ExcluirAluno();

            ExibirDados();
            LimparDados();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nomealuno = txtNome.Text;
            if (string.IsNullOrWhiteSpace(nomealuno))
            {
                MessageBox.Show("Insira o nome");
                return;
            }

            DataTable resultado = dadosAlunos.PesquisarAlunos(nomealuno);

            if (resultado.Rows.Count > 0)
            {
                dtgAlunos.DataSource = resultado;
            }
            else
            {
                MessageBox.Show("Nenhum aluno encontrado com o nome informado.");
            }

            dtgAlunos.DataSource = dadosAlunos.PesquisarAlunos(nomealuno);

        }
    }
}
