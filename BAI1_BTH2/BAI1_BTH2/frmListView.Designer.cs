namespace BAI1_BTH2
{
    partial class frmListView
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
            components = new System.ComponentModel.Container();
            ltvName = new ListView();
            colLast = new ColumnHeader();
            colFirst = new ColumnHeader();
            colPhone = new ColumnHeader();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            detailToolStripMenuItem = new ToolStripMenuItem();
            largeIconToolStripMenuItem = new ToolStripMenuItem();
            smallToolStripMenuItem = new ToolStripMenuItem();
            listToolStripMenuItem = new ToolStripMenuItem();
            tileToolStripMenuItem = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            lblView = new Label();
            panel1 = new Panel();
            lblPhone = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            btnAdd = new Button();
            txtPhone = new TextBox();
            txtFirst = new TextBox();
            txtLast = new TextBox();
            imageList1 = new ImageList(components);
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ltvName
            // 
            ltvName.Columns.AddRange(new ColumnHeader[] { colLast, colFirst, colPhone });
            ltvName.GridLines = true;
            ltvName.Location = new Point(12, 73);
            ltvName.Name = "ltvName";
            ltvName.Size = new Size(323, 291);
            ltvName.TabIndex = 0;
            ltvName.UseCompatibleStateImageBehavior = false;
            ltvName.View = View.Details;
            // 
            // colLast
            // 
            colLast.Text = "LastName";
            colLast.Width = 100;
            // 
            // colFirst
            // 
            colFirst.Text = "FirstNam";
            colFirst.Width = 100;
            // 
            // colPhone
            // 
            colPhone.Text = "Phone";
            colPhone.Width = 120;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, viewToolStripMenuItem, formatToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(643, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 25);
            fileToolStripMenuItem.Text = "File";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { detailToolStripMenuItem, largeIconToolStripMenuItem, smallToolStripMenuItem, listToolStripMenuItem, tileToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(56, 25);
            viewToolStripMenuItem.Text = "View";
            viewToolStripMenuItem.Click += viewToolStripMenuItem_Click;
            // 
            // detailToolStripMenuItem
            // 
            detailToolStripMenuItem.Name = "detailToolStripMenuItem";
            detailToolStripMenuItem.Size = new Size(152, 26);
            detailToolStripMenuItem.Text = "Detail";
            detailToolStripMenuItem.Click += detailToolStripMenuItem_Click;
            // 
            // largeIconToolStripMenuItem
            // 
            largeIconToolStripMenuItem.Name = "largeIconToolStripMenuItem";
            largeIconToolStripMenuItem.Size = new Size(152, 26);
            largeIconToolStripMenuItem.Text = "Large Icon";
            largeIconToolStripMenuItem.Click += largeIconToolStripMenuItem_Click;
            // 
            // smallToolStripMenuItem
            // 
            smallToolStripMenuItem.Name = "smallToolStripMenuItem";
            smallToolStripMenuItem.Size = new Size(152, 26);
            smallToolStripMenuItem.Text = "Small Icon";
            smallToolStripMenuItem.Click += smallToolStripMenuItem_Click;
            // 
            // listToolStripMenuItem
            // 
            listToolStripMenuItem.Name = "listToolStripMenuItem";
            listToolStripMenuItem.Size = new Size(152, 26);
            listToolStripMenuItem.Text = "List";
            listToolStripMenuItem.Click += listToolStripMenuItem_Click;
            // 
            // tileToolStripMenuItem
            // 
            tileToolStripMenuItem.Name = "tileToolStripMenuItem";
            tileToolStripMenuItem.Size = new Size(152, 26);
            tileToolStripMenuItem.Text = "Tile";
            tileToolStripMenuItem.Click += tileToolStripMenuItem_Click;
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(134, 25);
            formatToolStripMenuItem.Text = "Format ListView";
            // 
            // lblView
            // 
            lblView.AllowDrop = true;
            lblView.BorderStyle = BorderStyle.Fixed3D;
            lblView.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblView.Location = new Point(12, 38);
            lblView.Name = "lblView";
            lblView.Size = new Size(100, 23);
            lblView.TabIndex = 1;
            lblView.Text = "Detail";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblPhone);
            panel1.Controls.Add(lblFirstName);
            panel1.Controls.Add(lblLastName);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(txtFirst);
            panel1.Controls.Add(txtLast);
            panel1.Location = new Point(395, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 288);
            panel1.TabIndex = 2;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(29, 141);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(54, 21);
            lblPhone.TabIndex = 5;
            lblPhone.Text = "Phone";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(29, 78);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(82, 21);
            lblFirstName.TabIndex = 6;
            lblFirstName.Text = "FirstName";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(29, 17);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(84, 21);
            lblLastName.TabIndex = 5;
            lblLastName.Text = "Last Name";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(108, 223);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 44);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add Name";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(29, 165);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(166, 29);
            txtPhone.TabIndex = 3;
            // 
            // txtFirst
            // 
            txtFirst.Location = new Point(29, 102);
            txtFirst.Name = "txtFirst";
            txtFirst.Size = new Size(166, 29);
            txtFirst.TabIndex = 2;
            // 
            // txtLast
            // 
            txtLast.Location = new Point(29, 41);
            txtLast.Name = "txtLast";
            txtLast.Size = new Size(166, 29);
            txtLast.TabIndex = 1;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.DarkGray;
            // 
            // frmListView
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 380);
            Controls.Add(panel1);
            Controls.Add(lblView);
            Controls.Add(ltvName);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmListView";
            Text = "ListView Demo";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView ltvName;
        private ColumnHeader colLast;
        private ColumnHeader colFirst;
        private ColumnHeader colPhone;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private Label lblView;
        private Panel panel1;
        private Label lblPhone;
        private Label lblFirstName;
        private Label lblLastName;
        private Button btnAdd;
        private TextBox txtPhone;
        private TextBox txtLast;
        private TextBox txtFirst;
        private ToolStripMenuItem detailToolStripMenuItem;
        private ToolStripMenuItem largeIconToolStripMenuItem;
        private ToolStripMenuItem smallToolStripMenuItem;
        private ToolStripMenuItem listToolStripMenuItem;
        private ToolStripMenuItem tileToolStripMenuItem;
        private ImageList imageList1;
    }
}