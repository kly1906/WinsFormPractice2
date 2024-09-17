namespace BAI1_BTH2
{
    partial class frmCountry
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
            lblTitle = new Label();
            grbCountry = new GroupBox();
            rdbPhilippine = new RadioButton();
            rdbItalian = new RadioButton();
            rdbUSA = new RadioButton();
            rdbVietNam = new RadioButton();
            picFlag = new PictureBox();
            grbCountry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFlag).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(-3, -1);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(620, 95);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Country Flags";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grbCountry
            // 
            grbCountry.Controls.Add(rdbPhilippine);
            grbCountry.Controls.Add(rdbItalian);
            grbCountry.Controls.Add(rdbUSA);
            grbCountry.Controls.Add(rdbVietNam);
            grbCountry.Location = new Point(33, 97);
            grbCountry.Name = "grbCountry";
            grbCountry.Size = new Size(200, 207);
            grbCountry.TabIndex = 1;
            grbCountry.TabStop = false;
            grbCountry.Text = "Country";
            // 
            // rdbPhilippine
            // 
            rdbPhilippine.AutoSize = true;
            rdbPhilippine.Location = new Point(16, 163);
            rdbPhilippine.Name = "rdbPhilippine";
            rdbPhilippine.Size = new Size(97, 25);
            rdbPhilippine.TabIndex = 2;
            rdbPhilippine.TabStop = true;
            rdbPhilippine.Text = "Philippine";
            rdbPhilippine.UseVisualStyleBackColor = true;
            rdbPhilippine.CheckedChanged += rdbPhilippine_CheckedChanged;
            // 
            // rdbItalian
            // 
            rdbItalian.AutoSize = true;
            rdbItalian.Location = new Point(16, 121);
            rdbItalian.Name = "rdbItalian";
            rdbItalian.Size = new Size(70, 25);
            rdbItalian.TabIndex = 2;
            rdbItalian.TabStop = true;
            rdbItalian.Text = "Italian";
            rdbItalian.UseVisualStyleBackColor = true;
            rdbItalian.CheckedChanged += rdbItalian_CheckedChanged;
            // 
            // rdbUSA
            // 
            rdbUSA.AutoSize = true;
            rdbUSA.Location = new Point(16, 78);
            rdbUSA.Name = "rdbUSA";
            rdbUSA.Size = new Size(58, 25);
            rdbUSA.TabIndex = 2;
            rdbUSA.TabStop = true;
            rdbUSA.Text = "USA";
            rdbUSA.UseVisualStyleBackColor = true;
            rdbUSA.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rdbVietNam
            // 
            rdbVietNam.AutoSize = true;
            rdbVietNam.Location = new Point(16, 38);
            rdbVietNam.Name = "rdbVietNam";
            rdbVietNam.Size = new Size(89, 25);
            rdbVietNam.TabIndex = 2;
            rdbVietNam.TabStop = true;
            rdbVietNam.Text = "VietNam";
            rdbVietNam.UseVisualStyleBackColor = true;
            rdbVietNam.CheckedChanged += rdbVietNam_CheckedChanged;
            // 
            // picFlag
            // 
            picFlag.Location = new Point(276, 104);
            picFlag.Name = "picFlag";
            picFlag.Size = new Size(300, 200);
            picFlag.TabIndex = 2;
            picFlag.TabStop = false;
            // 
            // frmCountry
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 342);
            Controls.Add(picFlag);
            Controls.Add(grbCountry);
            Controls.Add(lblTitle);
            Name = "frmCountry";
            Text = "frmCountry";
            grbCountry.ResumeLayout(false);
            grbCountry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFlag).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private GroupBox grbCountry;
        private RadioButton rdbPhilippine;
        private RadioButton rdbItalian;
        private RadioButton rdbUSA;
        private RadioButton rdbVietNam;
        private PictureBox picFlag;
    }
}