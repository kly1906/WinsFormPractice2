namespace BAI1_BTH2
{
    partial class frmListView2
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
            txtAddress = new TextBox();
            txtName = new TextBox();
            txtClass = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtID = new TextBox();
            groupBox1 = new GroupBox();
            dtpBirth = new DateTimePicker();
            btnExit = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            label2 = new Label();
            listView1 = new ListView();
            colID = new ColumnHeader();
            colName = new ColumnHeader();
            colAddress = new ColumnHeader();
            colBirth = new ColumnHeader();
            colClass = new ColumnHeader();
            imageList1 = new ImageList(components);
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(148, 148);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(178, 29);
            txtAddress.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(148, 101);
            txtName.Name = "txtName";
            txtName.Size = new Size(178, 29);
            txtName.TabIndex = 2;
            // 
            // txtClass
            // 
            txtClass.Location = new Point(148, 255);
            txtClass.Name = "txtClass";
            txtClass.Size = new Size(178, 29);
            txtClass.TabIndex = 5;
            txtClass.TextChanged += textBox5_TextChanged;
            // 
            // label1
            // 
            label1.Location = new Point(24, 104);
            label1.Name = "label1";
            label1.Size = new Size(99, 21);
            label1.TabIndex = 0;
            label1.Text = "Họ tên";
            label1.TextAlign = ContentAlignment.TopRight;
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.Location = new Point(24, 151);
            label3.Name = "label3";
            label3.Size = new Size(99, 21);
            label3.TabIndex = 0;
            label3.Text = "Địa chỉ";
            label3.TextAlign = ContentAlignment.TopRight;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Location = new Point(24, 204);
            label4.Name = "label4";
            label4.Size = new Size(99, 21);
            label4.TabIndex = 0;
            label4.Text = "Ngày sinh";
            label4.TextAlign = ContentAlignment.TopRight;
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.Location = new Point(24, 258);
            label5.Name = "label5";
            label5.Size = new Size(99, 21);
            label5.TabIndex = 0;
            label5.Text = "Lớp";
            label5.TextAlign = ContentAlignment.TopRight;
            label5.Click += label5_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(148, 53);
            txtID.Name = "txtID";
            txtID.Size = new Size(178, 29);
            txtID.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpBirth);
            groupBox1.Controls.Add(btnExit);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtClass);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Location = new Point(24, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(711, 311);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sinh viên";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dtpBirth
            // 
            dtpBirth.Format = DateTimePickerFormat.Time;
            dtpBirth.Location = new Point(148, 204);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(178, 29);
            dtpBirth.TabIndex = 4;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(361, 234);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 50);
            btnExit.TabIndex = 9;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += button4_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(361, 175);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 50);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += button3_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(361, 113);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 50);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += Update_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(361, 53);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 50);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button1_Click;
            // 
            // label2
            // 
            label2.Location = new Point(24, 56);
            label2.Name = "label2";
            label2.Size = new Size(99, 21);
            label2.TabIndex = 0;
            label2.Text = "Mã SV";
            label2.TextAlign = ContentAlignment.TopRight;
            label2.Click += label1_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { colID, colName, colAddress, colBirth, colClass });
            listView1.Location = new Point(31, 367);
            listView1.Name = "listView1";
            listView1.Size = new Size(704, 201);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // colID
            // 
            colID.Text = "Mã";
            colID.Width = 100;
            // 
            // colName
            // 
            colName.Text = "Họ tên";
            colName.Width = 200;
            // 
            // colAddress
            // 
            colAddress.Text = "Địa chỉ";
            colAddress.Width = 180;
            // 
            // colBirth
            // 
            colBirth.Text = "Ngày sinh";
            colBirth.Width = 120;
            // 
            // colClass
            // 
            colClass.Text = "Lớp";
            colClass.Width = 100;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // frmListView2
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 586);
            Controls.Add(listView1);
            Controls.Add(groupBox1);
            Name = "frmListView2";
            Text = "frmListView2";
            Load += frmListView2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtAddress;
        private TextBox txtName;
        private TextBox txtClass;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtID;
        private GroupBox groupBox1;
        private Label label2;
        private Button btnExit;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnUpdate;
        private ListView listView1;
        private ColumnHeader colID;
        private ColumnHeader colName;
        private ColumnHeader colAddress;
        private ColumnHeader colBirth;
        private ColumnHeader colClass;
        private ImageList imageList1;
        private DateTimePicker dtpBirth;
    }
}