using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ex_01
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdd add = new frmAdd();
            add.Show();
        }

        private void editDeleteShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEdit fe=new frmEdit();
            fe.Show();
        }

        private void playerInfoReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportPage rp = new frmReportPage();
            rp.Show();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCoachAdd tf = new frmCoachAdd();
            tf.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowEdit se = new frmShowEdit();
            se.Show();
        }

        private void coachInformationReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCoachInformationReports tr = new frmCoachInformationReports();
            tr.Show();
        }

        private void addEditDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCRUD_withSP sp = new frmCRUD_withSP();
            sp.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}