using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class ManagePatient : Form
    {
        SqlConnection con;

        public ManagePatient()
        {
            InitializeComponent();
        }

        private void 환자관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient(con);
            patient.Show();
        }

        private void 진료작성ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clinic clinic = new Clinic(con);
            clinic.Show();
        }
    }
}
