using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MushroomForm : Form
    {
        public MushroomForm()
        {
            InitializeComponent();
        }

        private void MushroomForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            const decimal mushroomPrice = 5m;

            if (!int.TryParse(textBox1.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Enter a valid mushroom quantity.", "Invalid quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }

            textBox2.Text = (quantity * mushroomPrice).ToString("0.00");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



