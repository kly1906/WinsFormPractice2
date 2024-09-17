namespace BAI1_BTH2
{
    partial class frmCountdown
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblNoti = new Label();
            btnStart = new Button();
            btnStop = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblNoti
            // 
            lblNoti.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNoti.Location = new Point(94, 38);
            lblNoti.Name = "lblNoti";
            lblNoti.Size = new Size(156, 31);
            lblNoti.TabIndex = 0;
            lblNoti.Text = "Hết giờ!";
            lblNoti.TextAlign = ContentAlignment.MiddleCenter;
            lblNoti.Click += lblNoti_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(45, 100);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 41);
            btnStart.TabIndex = 1;
            btnStart.Text = "Bắt đầu";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(211, 100);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(75, 41);
            btnStop.TabIndex = 1;
            btnStop.Text = "Dừng";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // frmCountdown
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 171);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(lblNoti);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmCountdown";
            Text = "Đồng hồ đếm ngược";
            Load += frmCountdown_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblNoti;
        private Button btnStart;
        private Button btnStop;
        private System.Windows.Forms.Timer timer1;
    }
}