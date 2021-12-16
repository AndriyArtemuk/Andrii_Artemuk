using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Editing : Form
    {
        public Editing()
        {
            InitializeComponent();
        }


        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void replace_Click(object sender, EventArgs e)
        {
            string sqlStr;


            //Формуємо запит на редагування даних
            sqlStr = "UPDATE Animals SET " + tbSetToUpdate.Text + " WHERE " + tbWhereToUpdate.Text;

            if (MessageBox.Show("Ви впевнені, що хочете замінити дані?", "Заміна",
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
    }
}
