using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libraria
{
    public partial class frmMainForm : BaseForm
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void personatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonat fPersonat = new frmPersonat();
            fPersonat.Show();
        }

        private void shtëpitëBotueseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShtepiteBotuese fShBotuese = new frmShtepiteBotuese();
            fShBotuese.Show();
        }

        private void punëtorëtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPunetoret fPunetoret = new frmPunetoret();
            fPunetoret.Show();
        }

        private void libratToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLibrat flibrat = new frmLibrat();
            flibrat.Show();
        }

        private void faturatDalseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFatura faturaD = new frmFatura("D");
            faturaD.Show();
        }

        private void faturatHyrëseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFatura faturaD = new frmFatura("H");
            faturaD.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmListaFaturave lstFat = new frmListaFaturave();
            lstFat.Show();
        }

        private void ekzekutoQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryForm qyeryFrm = new QueryForm();
            qyeryFrm.Show();
        }
    }
}
