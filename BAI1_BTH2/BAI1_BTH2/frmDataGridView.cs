using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI1_BTH2
{
    public partial class frmDataGridView : Form
    {
        public frmDataGridView()
        {
            InitializeComponent();
        }

        private void frmDataGridView_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            DataGridViewRow item = new DataGridViewRow();
            item.CreateCells(dataGridView1);

            item.Cells[0].Value = txtId.Text;
            item.Cells[1].Value = txtName.Text;
            item.Cells[2].Value = txtCountry.Text;

            dataGridView1.Rows.Add(item);

            txtId.Clear();
            txtName.Clear();
            txtCountry.Clear();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            string id = txtId.Text;
            bool found = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == id)
                {
                    row.Cells[1].Value = txtName.Text.Length != 0 ? txtName.Text : row.Cells[1].Value;
                    row.Cells[2].Value = txtCountry.Text.Length != 0 ? txtCountry.Text : row.Cells[2].Value;
                    found = true;
                    break;
                }
            }
            if (found == false) { MessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            string id = txtId.Text;
            bool found = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == id)
                {
                    dataGridView1.Rows.Remove(row);
                    found = true;
                    break;
                }
            }
            if (found == false) { MessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btntSearch_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            bool found = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == id)
                {
                    row.Selected = true;
                    dataGridView1.CurrentCell = row.Cells[0];
                    found = true;
                    break;
                }
            }
            if (found == false) { MessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
