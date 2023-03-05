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
    public partial class MenuPage2 : Form
    {
        public MenuPage2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuList f2 = new MenuList();
            f2.Show();
            this.Hide();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
