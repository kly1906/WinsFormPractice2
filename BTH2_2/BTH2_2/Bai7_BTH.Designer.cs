namespace BTH2_2
{
    partial class Bai7_BTH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TreeNode treeNode1 = new TreeNode("NCTH3KA");
            TreeNode treeNode2 = new TreeNode("NCTH3KB");
            TreeNode treeNode3 = new TreeNode("CDTH11K");
            TreeNode treeNode4 = new TreeNode("Danh sách lớp", new TreeNode[] { treeNode1, treeNode2, treeNode3 });
            treeView1 = new TreeView();
            groupBox1 = new GroupBox();
            btnXoa = new Button();
            btnThem = new Button();
            txtDiachi = new TextBox();
            txtTen = new TextBox();
            txtMaSV = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.HideSelection = false;
            treeView1.Location = new Point(5, 12);
            treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "NCTH3KA";
            treeNode2.Name = "Node2";
            treeNode2.Text = "NCTH3KB";
            treeNode3.Name = "Node3";
            treeNode3.Text = "CDTH11K";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Danh sách lớp";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode4 });
            treeView1.Size = new Size(303, 381);
            treeView1.TabIndex = 0;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtDiachi);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(txtMaSV);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(314, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(474, 228);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sinh viên";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(292, 155);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 51);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(101, 155);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(95, 51);
            btnThem.TabIndex = 4;
            btnThem.Text = "Cập nhật";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtDiachi
            // 
            txtDiachi.Location = new Point(124, 101);
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Size = new Size(335, 29);
            txtDiachi.TabIndex = 3;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(124, 68);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(335, 29);
            txtTen.TabIndex = 2;
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(124, 33);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(335, 29);
            txtMaSV.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 109);
            label3.Name = "label3";
            label3.Size = new Size(57, 21);
            label3.TabIndex = 0;
            label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 71);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 0;
            label2.Text = "Họ tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 36);
            label1.Name = "label1";
            label1.Size = new Size(98, 21);
            label1.TabIndex = 0;
            label1.Text = "Mã sinh viên";
            // 
            // Bai7_BTH
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(795, 405);
            Controls.Add(groupBox1);
            Controls.Add(treeView1);
            MaximumSize = new Size(811, 445);
            MinimumSize = new Size(811, 445);
            Name = "Bai7_BTH";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bai7_BTH";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView1;
        private GroupBox groupBox1;
        private Button btnXoa;
        private Button btnThem;
        private TextBox txtDiachi;
        private TextBox txtTen;
        private TextBox txtMaSV;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}