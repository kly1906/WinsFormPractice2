using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH2_2
{
    public partial class Bai7_BTH : Form
    {
        public Bai7_BTH()
        {
            InitializeComponent();
        }


        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level == 2)
            {
                string[] ttsv = e.Node.Tag as string[];
                if (ttsv != null && ttsv.Length > 0)
                {
                    txtMaSV.Text = ttsv[0];
                    txtTen.Text = ttsv[1];
                    txtDiachi.Text = ttsv[2];
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string masv = txtMaSV.Text;
            string ten = txtTen.Text;
            string diachi = txtDiachi.Text;

            // Kiểm tra xem node được chọn có phải là sinh viên không
            if (treeView1.SelectedNode.Level != 1) //  level 0 là tiêu đề, level 1 là lớp, level 2 là sinh viên
            {
                MessageBox.Show("Vui lòng chọn một lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //kiểm tra mã sinh viên, tên, địa chỉ có để trống không
            if (string.IsNullOrEmpty(masv) || string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(diachi))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra mã sinh viên có trùng không trong tất cả lớp
            foreach (TreeNode classNode in treeView1.Nodes) // Duyệt qua tất cả lớp
            {
                foreach (TreeNode studentNode in classNode.Nodes) // Duyệt qua sinh viên trong mỗi lớp
                {
                    string[] part = studentNode.Text.Split('-');
                    if (part[0].Equals(masv))// So sánh mã sinh viên
                    {
                        MessageBox.Show("Mã sinh viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }

            //nếu tất cả điều kiện đúng thì thêm sinh viên vào lớp
            TreeNode svmoi = new TreeNode(masv + "-" + ten + "-" + diachi); //tạo node mới cho sinh viên cần thêm
            svmoi.Tag = new string[] { masv, ten, diachi };
            treeView1.SelectedNode.Nodes.Add(svmoi); ; //thêm node sinh viên vào lớp


            MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtMaSV.Clear();
            txtTen.Clear();
            txtDiachi.Clear();
            txtMaSV.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null)
            {
                MessageBox.Show("Vui lòng chọn một sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem node được chọn có phải là sinh viên không
            if (treeView1.SelectedNode.Level != 2) //  level 0 là tiêu đề, level 1 là lớp, level 2 là sinh viên
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên " + treeView1.SelectedNode.Text
                + " không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                treeView1.SelectedNode.Remove();
                MessageBox.Show("Đã xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSV.Clear();
                txtTen.Clear();
                txtDiachi.Clear();
                txtMaSV.Focus();
            }
        }
    }
}
