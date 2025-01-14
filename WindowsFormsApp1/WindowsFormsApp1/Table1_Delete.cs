﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Table1_Delete : Form
    {
        public Table1_Delete()
        {
            InitializeComponent();
        }

        private void Table1_delete_Load(object sender, EventArgs e)
        {
            textBox1.Text = h.keyName + " = " + h.curVal0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Формуємо запит на видалення таблиці
            string sqlStr = "DELETE FROM Animals WHERE " + textBox1.Text;

            if (MessageBox.Show("Ви впевнені, що хочете видалити запис", "Видалення",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (MySqlConnection con = new MySqlConnection(h.ConStr))
                {
                    MySqlCommand cmd = new MySqlCommand(sqlStr, con);

                    con.Open();                                 //Відкриваємо з'єднання
                    cmd.ExecuteNonQuery();                      //Виконуємо команду cmd
                    con.Close();                                //Закриваємо з'єднання
                }
            }
            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
