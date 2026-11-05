using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnExitThree_Click(object sender, EventArgs e)
        {

            Application.OpenForms["Form1"].Show();
            Application.OpenForms["Form2"].Close();
            this.Close();
        }

        private void btnIdentify_Click(object sender, EventArgs e)
        {
            DialogResult forest = MessageBox.Show("Does your mushroom grow in a forest?", "Question 1", MessageBoxButtons.YesNo);

            if (forest == DialogResult.Yes)
            {
                DialogResult cup = MessageBox.Show("Does your mushroom have a convex cup?", "Question 2", MessageBoxButtons.YesNo);

                if (cup == DialogResult.Yes)
                {
                    DialogResult ring = MessageBox.Show("Does your mushroom have a ring?", "Question 3", MessageBoxButtons.YesNo);

                    if (ring == DialogResult.Yes)
                    {
                        MessageBox.Show("Your mushroom is Amanite tue-mouche.");
                    }
                    else
                    {
                        MessageBox.Show("Your mushroom is Pied bleu.");
                    }
                }
                else
                {
                    DialogResult gills = MessageBox.Show("Does your mushroom have gills?", "Question 3", MessageBoxButtons.YesNo);

                    if (gills == DialogResult.Yes)
                    {
                        MessageBox.Show("Your mushroom is Girolle.");
                    }
                    else
                    {
                        MessageBox.Show("Your mushroom is Cepe de Bordeaux.");
                    }
                }
            }
            else
            {
                DialogResult cup = MessageBox.Show("Does your mushroom have a convex cup?", "Question 2", MessageBoxButtons.YesNo);

                if (cup == DialogResult.Yes)
                {
                    MessageBox.Show("Your mushroom is Agaric Jaunissant.");
                }
                else
                {
                    MessageBox.Show("Your mushroom is Coprin chevelu.");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form2"].Show();
            this.Close();
        }
    }
}
