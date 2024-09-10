using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prov_231009e231465
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btninserir_Click(object sender, EventArgs e)
        {
            dgvvendas.Rows.Add(txtprod.Text, txtqtde.Text, txtvalor.Text);
            MessageBox.Show("Item cadastrado na venda com sucesso!!", "Venda", MessageBoxButtons.OK);
            txtprod.Focus();
            double totalv = Convert.ToDouble(lblvalort.Text);
            totalv += Convert.ToDouble(txtvalor.Text) * Convert.ToDouble(txtqtde.Text);
            lblvalort.Text = totalv.ToString();
            txtvalor.Clear();
            txtprod.Clear();
            txtqtde.Clear();
            txtalterar.Clear();
        }

        private void btnremover_Click(object sender, EventArgs e)
        {
            if (dgvvendas.RowCount > 0)
            {
                MessageBox.Show("Item removido da venda com sucesso!!", "Remover", MessageBoxButtons.OK);
                double totalv = Convert.ToDouble(lblvalort.Text);
                totalv -= Convert.ToDouble(dgvvendas.CurrentRow.Cells[1].Value) * Convert.ToDouble(dgvvendas.CurrentRow.Cells[2].Value);

                lblvalort.Text = totalv.ToString();
                dgvvendas.Rows.RemoveAt(dgvvendas.CurrentCell.RowIndex);

                txtvalor.Clear();
                txtprod.Clear();
                txtqtde.Clear();
                txtalterar.Clear();

                txtprod.Focus();
            }
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Venda gravada com sucesso!!", "Gravar Venda", MessageBoxButtons.OK);

            if (dgvvendas.RowCount > 0)
            {
                dgvvendas.Rows.Clear();
                int vendas = Convert.ToInt32(lblvendas.Text);
                vendas++;
                lblvendas.Text = vendas.ToString();

                txtvalor.Clear();
                txtprod.Clear();
                txtqtde.Clear();
                txtalterar.Clear();

                lblvalort.Text = "0";

                txtprod.Focus();
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            if (dgvvendas.RowCount > 0)
            {
                MessageBox.Show("Venda cancelada com sucesso!!", "Cancelar Venda", MessageBoxButtons.OK);
            }

            dgvvendas.Rows.Clear();
            txtvalor.Clear();
            txtprod.Clear();
            txtqtde.Clear();
            txtalterar.Clear();

            lblvalort.Text = "0";

            txtprod.Focus();
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvvendas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvvendas.RowCount > 0)
            {
                txtalterar.Text = dgvvendas.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void btnalterarqtde_Click(object sender, EventArgs e)
        {
            if (txtalterar.Text != "")
            {
                MessageBox.Show("Quantidade alterada com sucesso!!", "Alterar", MessageBoxButtons.OK);

                double totalv = Convert.ToDouble(lblvalort.Text);
                totalv -= Convert.ToDouble(dgvvendas.CurrentRow.Cells[1].Value) * Convert.ToDouble(dgvvendas.CurrentRow.Cells[2].Value);

                dgvvendas.CurrentRow.Cells[1].Value = txtalterar.Text;

                totalv += Convert.ToDouble(dgvvendas.CurrentRow.Cells[1].Value) * Convert.ToDouble(dgvvendas.CurrentRow.Cells[2].Value);
                lblvalort.Text = totalv.ToString();
            }
        }
    }
}
