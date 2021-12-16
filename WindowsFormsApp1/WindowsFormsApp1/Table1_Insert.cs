
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
    public partial class Table1_Insert : Form
    {
        public Table1_Insert()
        {
            InitializeComponent();
        }

  


        private void btnInsert_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(h.ConStr))
            {
                //Читаємо дані з форми Table1_Insert
                string tb1 = textBox1.Text;
                string tb2 = textBox2.Text;
                string tb3 = textBox3.Text;
                string tb4 = textBox4.Text;
                string tb5 = DateTime.Parse(textBox5.Text).ToString("yyyy-MM-dd");
                    //.ToDataTime(textBox5.Text);
                string tb6 = textBox6.Text;

         //       int FileSize;
         //       byte[] rawData;
          //      FileStream fs;
          //      string strFileName;

              //  strFileName = h.pathToPhoto;
          //      fs = new FileStream(strFileName, FileMode.Open, FileAccess.Read);
          /*      FileSize = (Int32)fs.Length;
                rawData = new byte[FileSize];
                fs.Read(rawData, 0, FileSize);
                fs.Close();
          */
                //Формуємо команду для додавання запису
                string sql = "INSERT INTO Animals " +
                    "(idAnimals,name, region, Vaga, intzavd, Size)" +
                    " VALUES (@TK1, @TK2, @TK3, @TK4, @TK5, @TK6 )";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                //Додаємо параметри у колекцію класу Command
                cmd.Parameters.AddWithValue("@TK1", tb1);
                cmd.Parameters.AddWithValue("@TK2", tb2);
                cmd.Parameters.AddWithValue("@TK3", tb3);
                cmd.Parameters.AddWithValue("@TK4", tb4);
                cmd.Parameters.AddWithValue("@TK5", tb5);
                cmd.Parameters.AddWithValue("@TK6", tb6);

              //  MessageBox.Show(sql);

            //    cmd.Parameters.AddWithValue("@File", rawData);

                con.Open();                             //Відкриваємо з'єднання
                cmd.ExecuteNonQuery();                  //Виконуємо команду cmd
                con.Close();                            //Закриваємо з'єднання

                MessageBox.Show("Додавання запису пройшло вдало");
            
            }
            this.Close();
        }
                
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
