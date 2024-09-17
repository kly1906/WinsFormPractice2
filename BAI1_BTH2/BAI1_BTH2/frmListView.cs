using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BAI1_BTH2
{
    public partial class frmListView : Form
    {
        public frmListView()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtLast.Text.Length > 0 && txtFirst.Text.Length > 0 && txtPhone.Text.Length > 0)
            {
                ListViewItem item = new ListViewItem(txtLast.Text);

                // Thêm các giá trị từ các TextBox vào các subitems

                item.SubItems.Add(txtFirst.Text);
                item.SubItems.Add(txtPhone.Text);

                // Thêm ListViewItem vào ListView
                ltvName.Items.Add(item);
                
                // Xóa nội dung của các TextBox sau khi thêm dữ liệu
                txtLast.Clear();
                txtFirst.Clear();
                txtPhone.Clear();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void detailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ltvName.View = View.Details;
            lblView.Text = "Detail";
        }

        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ltvName.View = View.LargeIcon;
            lblView.Text = "Large Icon";
        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ltvName.View = View.SmallIcon;
            lblView.Text = "Small Icon";
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ltvName.View = View.List;
            lblView.Text = "List";
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ltvName.View = View.Tile;
            lblView.Text = "Tile";
        }
    }
}
