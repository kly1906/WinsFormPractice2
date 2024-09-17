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
    public partial class frmListView2 : Form
    {
        public frmListView2()
        {
            InitializeComponent();
            dtpBirth.MaxDate = DateTime.Now;
        }

        private void frmListView2_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ID_Search = txtID.Text;
            bool found = false;

            foreach (ListViewItem item in listView1.Items)
            {
                // Giả sử cột đầu tiên chứa ID
                if (item.SubItems[0].Text == ID_Search)
                {
                    listView1.Items.Remove(item);
                    found = true;
                    break; // Dừng vòng lặp khi đã tìm thấy
                }
            }
            if (found == false)
            {
                MessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 0 && txtID.Text.Length > 0 &&
                txtAddress.Text.Length > 0 &&
                txtClass.Text.Length > 0)

            {
                ListViewItem item = new ListViewItem(txtID.Text);

                item.SubItems.Add(txtName.Text);
                item.SubItems.Add(txtAddress.Text);
                item.SubItems.Add(dtpBirth.Text);
                item.SubItems.Add(txtClass.Text);

                listView1.Items.Add(item);

                txtID.Clear();
                txtName.Clear();
                txtAddress.Clear();
                dtpBirth.Refresh();
                txtClass.Clear();

            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            string ID_Search = txtID.Text;
            bool found = false;

            foreach (ListViewItem item in listView1.Items)
            {
                // Giả sử cột đầu tiên chứa ID
                if (item.SubItems[0].Text == ID_Search)
                {
                    // Cập nhật thông tin của ListViewItem
                    item.SubItems[1].Text = txtName.Text==""? item.SubItems[1].Text : txtName.Text;
                    item.SubItems[2].Text = txtAddress.Text==""? item.SubItems[2].Text : txtAddress.Text;
                    item.SubItems[3].Text = dtpBirth.Text == item.SubItems[3].Text? item.SubItems[3].Text : dtpBirth.Text;
                    item.SubItems[4].Text = txtClass.Text =="" ? item.SubItems[4].Text : txtClass.Text;

                    found = true;
                    break; // Dừng vòng lặp khi đã tìm thấy
                }
            }
            if (found == false)
            {
                MessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


    }
}
