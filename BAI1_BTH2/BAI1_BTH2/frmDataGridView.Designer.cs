namespace BAI1_BTH2
{
    partial class frmDataGridView
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
            errorProvider1 = new ErrorProvider(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            txtCountry = new TextBox();
            dataGridView1 = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colCountry = new DataGridViewTextBoxColumn();
            button1 = new Button();
            btnEnter = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btntSearch = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 26);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 0;
            label1.Text = "Mã SV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(160, 26);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 0;
            label2.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(402, 26);
            label3.Name = "label3";
            label3.Size = new Size(78, 21);
            label3.TabIndex = 0;
            label3.Text = "Quê quán";
            // 
            // txtId
            // 
            txtId.Location = new Point(17, 59);
            txtId.Name = "txtId";
            txtId.Size = new Size(104, 29);
            txtId.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(160, 59);
            txtName.Name = "txtName";
            txtName.Size = new Size(201, 29);
            txtName.TabIndex = 1;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(402, 59);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(130, 29);
            txtCountry.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colID, colName, colCountry });
            dataGridView1.Location = new Point(17, 121);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 31;
            dataGridView1.Size = new Size(567, 382);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // colID
            // 
            colID.HeaderText = "Mã SV";
            colID.Name = "colID";
            // 
            // colName
            // 
            colName.HeaderText = "Name";
            colName.Name = "colName";
            // 
            // colCountry
            // 
            colCountry.HeaderText = "Quê quán";
            colCountry.Name = "colCountry";
            // 
            // button1
            // 
            button1.Location = new Point(656, 55);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(631, 48);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(75, 40);
            btnEnter.TabIndex = 4;
            btnEnter.Text = "Nhập";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(631, 107);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 40);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(631, 168);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 40);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btntSearch
            // 
            btntSearch.Location = new Point(631, 229);
            btntSearch.Name = "btntSearch";
            btntSearch.Size = new Size(75, 40);
            btntSearch.TabIndex = 4;
            btntSearch.Text = "Tìm";
            btntSearch.UseVisualStyleBackColor = true;
            btntSearch.Click += btntSearch_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(631, 288);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 40);
            btnExit.TabIndex = 4;
            btnExit.Text = "Kết thúc";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmDataGridView
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 544);
            Controls.Add(btnExit);
            Controls.Add(btntSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnEnter);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(txtCountry);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmDataGridView";
            Text = "frmDataGridView";
            Load += frmDataGridView_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProvider1;
        private TextBox txtCountry;
        private TextBox txtName;
        private TextBox txtId;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colCountry;
        private Button btnExit;
        private Button btntSearch;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnEnter;
        private Button button1;
    }
}