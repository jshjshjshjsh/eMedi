using forGUI;
using project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;
using WinFormsApp2;

namespace ex_main
{
    public partial class DesignTool : Form
    {
        public DesignTool()
        {
            InitializeComponent();
        }

        private void 파일ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 미리보기ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 출력ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void 미리보기ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Preview preview = new Preview();
            preview.Show();
        }

        private void 인쇄ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Printing printing = new Printing();
            printing.Show();
        }

        private void 용지ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocSetting docSetting = new DocSetting();  
            docSetting.Show();
        }

        private void 쪽ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocSetting docSetting = new DocSetting();
            docSetting.Show();
        }

        private void 인쇄_Click(object sender, EventArgs e)
        {

            Printing printing = new Printing();
            printing.Show();
        }

        private void 미리보기_Click(object sender, EventArgs e)
        {

            DocSetting docSetting = new DocSetting();
            docSetting.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 환자관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagePatient managePatient = new ManagePatient();
            managePatient.Show();   
        }

        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
