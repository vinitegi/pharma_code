using ProjetoFinal.Entities;
using ProjetoFinal.Repositories;
using System;
using System.Drawing;
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
            EstilizarGrid();
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

        private void EstilizarGrid()
        {
            dgvCategorias.BorderStyle = BorderStyle.None;
            dgvCategorias.BackgroundColor = Color.White;
            dgvCategorias.EnableHeadersVisualStyles = false;

            dgvCategorias.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243);
            dgvCategorias.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCategorias.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvCategorias.ColumnHeadersHeight = 35;

            dgvCategorias.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvCategorias.DefaultCellStyle.BackColor = Color.White;
            dgvCategorias.DefaultCellStyle.ForeColor = Color.Black;
            dgvCategorias.DefaultCellStyle.SelectionBackColor = Color.FromArgb(187, 222, 251);
            dgvCategorias.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvCategorias.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);

            dgvCategorias.RowTemplate.Height = 32;
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.MultiSelect = false;
            dgvCategorias.ReadOnly = true;
        }
    }
}