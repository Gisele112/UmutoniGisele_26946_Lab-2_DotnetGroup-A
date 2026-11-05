using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnBicycle_Click(object sender, EventArgs e)
        {
            Form4 bicycle = new Form4();
            bicycle.Show();
            this.Hide();
        }

        private void btnMushRoom_Click(object sender, EventArgs e)
        {
            Form3 mushroom = new Form3();
            mushroom.Show();
            this.Hide();
        }
    }
}
