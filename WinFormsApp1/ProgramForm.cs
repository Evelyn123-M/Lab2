using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ProgramForm : Form
    {
        public ProgramForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using var bicycleForm = new BicycleForm();
            bool logout = bicycleForm.ShowDialog(this) == DialogResult.OK;

            if (logout)
            {
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using var mealForm = new MushroomForm();
            bool logout = mealForm.ShowDialog(this) == DialogResult.OK;

            if (logout)
            {
                Close();
            }
        }
    }
}
