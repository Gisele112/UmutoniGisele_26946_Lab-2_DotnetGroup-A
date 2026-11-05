using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnExitFour_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form1"].Show();
            Application.OpenForms["Form2"].Close();
            this.Close();
        }

        private void btnCaculate_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(txtStart.Text);
                int end = Convert.ToInt32(txtEnd.Text);

                if (start < 0 || start > 23)
                {
                    MessageBox.Show("Start time must be between 0 and 23.");
                }
                else if (end < 1 || end > 24)
                {
                    MessageBox.Show("End time must be between 1 and 24.");
                }
                else if (start >= end)
                {
                    MessageBox.Show("Start time must be less than end time.");
                }
                else
                {
                    int total = 0;

                    for (int hour = start; hour < end; hour++)
                    {
                        if (hour >= 0 && hour <= 6)
                        {
                            total = total + 500;
                        }
                        else if (hour >= 7 && hour <= 13)
                        {
                            total = total + 1000;
                        }
                        else if (hour >= 14 && hour <= 18)
                        {
                            total = total + 1500;
                        }
                        else if (hour >= 19 && hour <= 20)
                        {
                            total = total + 1000;
                        }
                        else
                        {
                            total = total + 500;
                        }
                    }

                    txtTotal.Text = total.ToString();
                    MessageBox.Show("The total is " + total + " RWF");
                }
            }
            catch
            {
                MessageBox.Show("Please enter whole numbers only.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form2"].Show();
            this.Close();
        }
    }
}
