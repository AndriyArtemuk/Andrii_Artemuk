﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Calc1 : Form
    {
        public Calc1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Calc1_load(object sender, EventArgs e)
        {
            cmbxAct.Items.Add("+");
            cmbxAct.Items.Add("-");
            cmbxAct.Items.Add("*");
            cmbxAct.Items.Add("/");

            cmbxAct.Text = "+";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            double ch1, ch2;
            if (txtCh1.Text == "") ch1 = 0; else ch1 = double.Parse(txtCh1.Text);
            if (txtCh2.Text == "") ch2 = 0; else ch2 = Convert.ToDouble(txtCh2.Text);

            if (cmbxAct.SelectedIndex == 0)
                txtRez.Text = (ch1 + ch2).ToString();
            else if (cmbxAct.SelectedIndex == 1)
                txtRez.Text = (ch1 - ch2).ToString();
            else if (cmbxAct.SelectedIndex == 2)
                txtRez.Text = (ch1 * ch2).ToString();
            else if (cmbxAct.SelectedIndex == 3)
                txtRez.Text = (ch1 / ch2).ToString();
        }

        private void btnExit_Click_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
