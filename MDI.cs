using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MDI : Form
    {
        Form1 x = new Form1();
        Form2 x2 = new Form2();
        public MDI()
        {
            InitializeComponent();
        }

        private void innsLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x.MdiParent = this;
            x.Show();

        }

        private void utilidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x2.MdiParent = this;
            x2.Show();

        }
    }
}
