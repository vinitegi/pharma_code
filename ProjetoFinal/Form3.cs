using ProjetoFinal.Entities;
using ProjetoFinal.Repositories;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoFinal
{
    public partial class Form3 : Form
    {
        RemedioRepository repository = new RemedioRepository();
        CategoriaRepository categoriaRepository = new CategoriaRepository();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            CarregarCategorias();
            EstilizarGrid();
            AtualizarGrid();
        }

        private void CarregarCategorias()
        {
            cmbCategoria.DataSource = categoriaRepository.Listar();
            cmbCategoria.DisplayMember = "Nome";
            cmbCategoria.ValueMember = "Id";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Remedio remedio = new Remedio();

            remedio.Nome = txtNome.Text;
            remedio.Preco = Convert.ToDecimal(txtPreco.Text);
            remedio.Quantidade = Convert.ToInt32(txtQuantidade.Text);
            remedio.Validade = dtpValidade.Value;
            remedio.CategoriaId = Convert.ToInt32(cmbCategoria.SelectedValue);

            repository.Inserir(remedio);

            MessageBox.Show("Remédio cadastrado!");
            AtualizarGrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Remedio remedio = new Remedio();

            remedio.Id = Convert.ToInt32(txtId.Text);
            remedio.Nome = txtNome.Text;
            remedio.Preco = Convert.ToDecimal(txtPreco.Text);
            remedio.Quantidade = Convert.ToInt32(txtQuantidade.Text);
            remedio.Validade = dtpValidade.Value;
            remedio.CategoriaId = Convert.ToInt32(cmbCategoria.SelectedValue);

            repository.Editar(remedio);

            MessageBox.Show("Remédio editado!");
            AtualizarGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);

            repository.Deletar(id);

            MessageBox.Show("Remédio removido!");
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            dgvRemedios.DataSource = repository.Listar();
        }

        private void EstilizarGrid()
        {
            dgvRemedios.BorderStyle = BorderStyle.None;
            dgvRemedios.BackgroundColor = Color.White;
            dgvRemedios.EnableHeadersVisualStyles = false;

            dgvRemedios.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243);
            dgvRemedios.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvRemedios.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvRemedios.ColumnHeadersHeight = 35;

            dgvRemedios.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvRemedios.DefaultCellStyle.BackColor = Color.White;
            dgvRemedios.DefaultCellStyle.ForeColor = Color.Black;
            dgvRemedios.DefaultCellStyle.SelectionBackColor = Color.FromArgb(187, 222, 251);
            dgvRemedios.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvRemedios.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);

            dgvRemedios.RowTemplate.Height = 32;
            dgvRemedios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRemedios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRemedios.MultiSelect = false;
            dgvRemedios.ReadOnly = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}