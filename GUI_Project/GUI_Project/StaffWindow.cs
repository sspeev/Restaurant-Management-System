using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Project
{
    public partial class StaffWindow : Form
    {
        private List<int> list = new List<int>();
        public StaffWindow()
        {
            InitializeComponent();
        }
        public StaffWindow(int price):this()
        {
            list.Add(price);
            InitializeComponent();
        }

        public void HomeButton_Click(object sender, EventArgs e)
        {
            Resturant_Manegment_System f1 = new Resturant_Manegment_System();
            f1.Show();
            this.Hide();
        }

        public void button3_Click(object sender, EventArgs e)
        {
            MenuList f2 = new MenuList();
            f2.Show();
            this.Hide();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void StaffWindow_Load(object sender, EventArgs e)
        {
            ProgressBar.Value = list.Sum();
        }
    }
}
