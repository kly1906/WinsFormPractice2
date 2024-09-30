namespace BTH2_2
{
    partial class Bai6_BTH2
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
            TreeNode treeNode1 = new TreeNode("Nguyen van Tuan");
            TreeNode treeNode2 = new TreeNode("Nguyen thi Lan");
            TreeNode treeNode3 = new TreeNode("Nguyen van Luong");
            TreeNode treeNode4 = new TreeNode("THTH5A", new TreeNode[] { treeNode1, treeNode2, treeNode3 });
            TreeNode treeNode5 = new TreeNode("le Nghiep");
            TreeNode treeNode6 = new TreeNode("Tran Long");
            TreeNode treeNode7 = new TreeNode("Ly Hai");
            TreeNode treeNode8 = new TreeNode("THTH5B", new TreeNode[] { treeNode5, treeNode6, treeNode7 });
            TreeNode treeNode9 = new TreeNode("Le Trung");
            TreeNode treeNode10 = new TreeNode("Ton thi Mai");
            TreeNode treeNode11 = new TreeNode("THTH5C", new TreeNode[] { treeNode9, treeNode10 });
            TreeNode treeNode12 = new TreeNode("Khoa tin hoc", new TreeNode[] { treeNode4, treeNode8, treeNode11 });
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            treeView1 = new TreeView();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView1.GridLines = true;
            listView1.Location = new Point(332, 74);
            listView1.Name = "listView1";
            listView1.Size = new Size(323, 279);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Ten SV";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Lop";
            columnHeader2.Width = 100;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(10, 74);
            treeView1.Name = "treeView1";
            treeNode1.Name = "Node4";
            treeNode1.Text = "Nguyen van Tuan";
            treeNode2.Name = "Node5";
            treeNode2.Text = "Nguyen thi Lan";
            treeNode3.Name = "Node6";
            treeNode3.Text = "Nguyen van Luong";
            treeNode4.Name = "Node1";
            treeNode4.Text = "THTH5A";
            treeNode5.Name = "Node7";
            treeNode5.Text = "le Nghiep";
            treeNode6.Name = "Node8";
            treeNode6.Text = "Tran Long";
            treeNode7.Name = "Node9";
            treeNode7.Text = "Ly Hai";
            treeNode8.Name = "Node2";
            treeNode8.Text = "THTH5B";
            treeNode9.Name = "Node10";
            treeNode9.Text = "Le Trung";
            treeNode10.Name = "Node11";
            treeNode10.Text = "Ton thi Mai";
            treeNode11.Name = "Node3";
            treeNode11.Text = "THTH5C";
            treeNode12.Name = "Node0";
            treeNode12.Text = "Khoa tin hoc";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode12 });
            treeView1.Size = new Size(301, 279);
            treeView1.TabIndex = 1;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(332, 26);
            label1.Name = "label1";
            label1.Size = new Size(74, 21);
            label1.TabIndex = 2;
            label1.Text = "Nhap ten";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(412, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 29);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(580, 21);
            button1.Name = "button1";
            button1.Size = new Size(75, 31);
            button1.TabIndex = 4;
            button1.Text = "Tìm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Bai6_BTH2
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(666, 361);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(treeView1);
            Controls.Add(listView1);
            Name = "Bai6_BTH2";
            Text = "Bai6_BTH2";
            Load += Bai6_BTH2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private TreeView treeView1;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
    }
}