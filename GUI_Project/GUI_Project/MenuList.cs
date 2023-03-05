using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Project
{
    public partial class MenuList : Form
    {
        private int globalVariable;
        public void HidePanels()
        {
            foreach (var control in Controls)
                if (control is Panel)
                    ((Panel)control).Visible = false;
        }
        public void ShowPanels()
        {
            foreach (var control in Controls)
                if (control is Panel)
                    ((Panel)control).Visible = true;
        }
        public MenuList()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            //empty

        }
        private void closeButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void HomeButton_Click(object sender, EventArgs e)
        {
            Resturant_Manegment_System f1 = new Resturant_Manegment_System();
            f1.Show();
            this.Hide();
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //empty
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string input = SearchBox.Text;
            HidePanels();
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
            switch (input)
            {
                case "Spagetti":
                    panel4.Visible = true;
                    panel4.Location = new Point(7, 7);

                    break;
                case "Soft Pudding":
                    panel5.Visible = true;
                    panel5.Location = new Point(7, 7);
                    break;
                case "Chocolate Cake":
                    panel6.Visible = true;
                    panel6.Location = new Point(7, 7);
                    break;
                case "Teriyaki":
                    panel7.Visible = true;
                    panel7.Location = new Point(7, 7);
                    break;
                case "Bruschetta":
                    panel8.Visible = true;
                    panel8.Location = new Point(7, 7);
                    break;
                case "Pulled Pork":
                    panel9.Visible = true;
                    panel9.Location = new Point(7, 7);
                    break;
                default:
                    ShowPanels();
                    panel4.Location = new Point(7, 7);
                    panel5.Location = new Point(267, 10);
                    panel6.Location = new Point(526, 10);
                    panel7.Location = new Point(14, 208);
                    panel8.Location = new Point(267, 215);
                    panel9.Location = new Point(526, 218);
                    break;
            }
        }

        private void staffButton_Click(object sender, EventArgs e)
        {
            StaffWindow f3 = new StaffWindow(globalVariable);
            f3.Show();
            this.Hide();
        }

        private void NextPageButton_Click(object sender, EventArgs e)
        {
            MenuPage2 f4 = new MenuPage2();
            f4.Show();
            this.Hide();
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            //panel4
            StringBuilder sb = new StringBuilder();
            foreach (var item in label3.Text)
            {
                if (char.IsNumber(item))
                {
                    sb.Append(item);
                }
            }
            int price = int.Parse(sb.ToString());
            globalVariable = price;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //orderButton for soft pudding
            StringBuilder sb = new StringBuilder();
            foreach (var item in label5.Text)
            {
                if (char.IsNumber(item))
                {
                    sb.Append(item);
                }
            }
            int price = int.Parse(sb.ToString());
            globalVariable = price;
        }
    }
}
