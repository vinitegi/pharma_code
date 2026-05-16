using ProjetoFinal.Entities;
using ProjetoFinal.Repositories;
using System;
using System.Windows.Forms;

namespace ProjetoFinal
{
    public partial class Form1 : Form
    {
        CategoriaRepository repository = new CategoriaRepository();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();

            categoria.Nome = txtNome.Text;

            repository.Inserir(categoria);

            MessageBox.Show("Categoria cadastrada!");

            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            dgvCategorias.DataSource = repository.Listar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);

            repository.Deletar(id);

            MessageBox.Show("Categoria removida!");

            AtualizarGrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();

            categoria.Id = Convert.ToInt32(txtId.Text);
            categoria.Nome = txtNome.Text;

            repository.Editar(categoria);

            MessageBox.Show("Categoria editada!");

            AtualizarGrid();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}