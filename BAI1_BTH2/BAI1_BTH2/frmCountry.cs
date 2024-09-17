using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace BAI1_BTH2
{
    public partial class frmCountry : Form
    {
        public frmCountry()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            picFlag.ImageLocation = Application.StartupPath + "\\" + rdbUSA.Text + ".png";
            //ImageLocation là thuộc tính của PictureBox dùng để đặt đường dẫn cho hình ảnh hiển thị.
            picFlag.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void rdbVietNam_CheckedChanged(object sender, EventArgs e)
        {
            //picFlag.Image = Image.FromFile(@"C:\Users\PC\Downloads\lá cờ việt nam.PNG");

            picFlag.ImageLocation = Application.StartupPath + "\\" + rdbVietNam.Text + ".png";
            //ImageLocation là thuộc tính của PictureBox dùng để đặt đường dẫn cho hình ảnh hiển thị.

            picFlag.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void rdbItalian_CheckedChanged(object sender, EventArgs e)
        {
            picFlag.ImageLocation = Application.StartupPath + "\\" + rdbItalian.Text + ".png";
            //ImageLocation là thuộc tính của PictureBox dùng để đặt đường dẫn cho hình ảnh hiển thị.
            picFlag.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void rdbPhilippine_CheckedChanged(object sender, EventArgs e)
        {
            picFlag.ImageLocation = Application.StartupPath + "\\" + rdbPhilippine.Text + ".png";
            //ImageLocation là thuộc tính của PictureBox dùng để đặt đường dẫn cho hình ảnh hiển thị.
            picFlag.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
