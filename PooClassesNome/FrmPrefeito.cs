using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PooClassesNome
{
    public partial class FrmPrefeito : Form
    {
        public FrmPrefeito()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void prefeitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrefeito frm = new FrmPrefeito();// indica qual ser aberto
            this.Hide();// fecha o atual
            frm.ShowDialog();
        }

        private void alimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlimento frm = new FrmAlimento();// indica qual ser aberto
            this.Hide();// fecha o atual
            frm.ShowDialog();
        }

        private void lojaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLoja frm = new FrmLoja();// indica qual ser aberto
            this.Hide();// fecha o atual
            frm.ShowDialog();
        }
    }
}
