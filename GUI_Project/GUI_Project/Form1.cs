using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;

namespace GUI_Project
{
    public partial class Resturant_Manegment_System : Form
    {
        SoundPlayer splayer = new SoundPlayer(@"../../../SilkJazz.wav");
        public Resturant_Manegment_System()
        {
            InitializeComponent();
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void HomeButton_Click(object sender, EventArgs e)
        {
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MenuList f2 = new MenuList();
            f2.Show();
            this.Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            StaffWindow f3 = new StaffWindow();
            f3.Show();
            this.Hide();
        }
        private void InstagramButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/_stoyan.peev.520_/");
        }

        private void FaceBookButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/stoyan.peev.520");
        }

        private void TelegramButton_Click(object sender, EventArgs e)
        {

        }
    }
}
