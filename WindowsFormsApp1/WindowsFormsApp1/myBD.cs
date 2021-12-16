using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class myBD : Form
    {
        public myBD()
        {
            InitializeComponent();
        }

        private void exirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About f0 = new About();
            f0.ShowDialog();
        }

        private void calk1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calc1 f1 = new Calc1();
            f1.ShowDialog();
        }

        private void calk2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calc2 f2 = new Calc2();
            f2.ShowDialog();
        }

        private void tableBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            t1Agrobiologia t1 = new t1Agrobiologia();
            t1.ShowDialog();
        }

        private void animalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            t1Agrobiologia f1 = new t1Agrobiologia();
            f1.ShowDialog();
        }
    }
}
