namespace BAI1_BTH2
{
    public partial class frmCountdown : Form
    {
        public frmCountdown()
        {
            InitializeComponent();

        }
        int i = 20;
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblNoti.Text = i.ToString();
            i--;
            if (i < 0)
                this.timer1.Enabled = false;

        }

        private void lblNoti_Click(object sender, EventArgs e)
        {

        }

        private void frmCountdown_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            //timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}