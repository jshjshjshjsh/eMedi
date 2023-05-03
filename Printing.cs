using System;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Printing : Form
    {
        public Printing()
        {
            InitializeComponent();
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}