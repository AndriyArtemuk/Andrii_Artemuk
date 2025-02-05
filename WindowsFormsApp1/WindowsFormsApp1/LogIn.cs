﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace WindowsFormsApp1
{
    public partial class LogIn : Form
    {
        public string[,] matrix;
        DataTable dt;
        public LogIn()
        {
            InitializeComponent();

            string IPSQLServer = "193.93.216.145";//для домашнік пк та ноутбуків
            string LogSQLServer = "sqlist19_1_aa";
            string PassSQLServer = "ist19_aa";

            h.ConStr = "Server = " + IPSQLServer + "; characterset = cp1251;" +
                "user = " + LogSQLServer + "; database = " + LogSQLServer + "; password = " + PassSQLServer;

            dt = h.MyfunDt("Select * from User_name");//читаємо таблицю userName в dt
            int count = dt.Rows.Count;//кількість записів в таблиці userName

            matrix = new string[count, 4];
            for (int i = 0; i < count; i++)
            {
                matrix[i, 0] = dt.Rows[i].Field<int>("id").ToString();
                matrix[i, 1] = dt.Rows[i].Field<string>("UserName");
                matrix[i, 2] = dt.Rows[i].Field<int>("Type").ToString();
                matrix[i, 3] = dt.Rows[i].Field<string>("Password");
                cbxUser.Items.Add(matrix[i, 1]);//формуємо список користувачів в comboBox cbxUser
            }
            cbxUser.Text = matrix[0, 1];//ініціалізуємо 1-го користувача
            txtPassword.UseSystemPasswordChar = true;
            cbxUser.Focus();
        }
        private void Authorization()
        {
            bool flUser = false;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
               // MessageBox.Show(txtPassword.Text + "     " + matrix[i, 3].ToString());
                if (String.Equals(cbxUser.Text.ToUpper(), matrix[i, 1].ToUpper()))
                {
                    flUser = true;
                    if (String.Equals(h.EncriptedPassword(txtPassword.Text), matrix[i, 3]))
                    {
                        h.nameUser = matrix[i, 1];
                        h.typeUser = matrix[i, 2];
                        cbxUser.Text = "";
                        txtPassword.Text = "";
                        this.Hide();//Close закриває проект...
                        myBD f0 = new myBD();
                        
                        f0.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Введіть правильний пароль!", "Помилка авторизації",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                        txtPassword.Text = "";
                        txtPassword.Focus();
                    }
                }
            }
            if (!flUser)
            {
                MessageBox.Show("Користувач '" + cbxUser.Text + "' не зареєстрований в системі! " +
                    "\nЗверніться до адміністратора...", "Помилка авторизації",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbxUser.Text = "";
                cbxUser.Focus();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Authorization();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbxUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Authorization();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Authorization();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }
        private void btnOk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Authorization();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void btnExit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Authorization();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void LogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            //textBox1.Text = h.EncriptedPassword(txtPassword.Text);
            
            Authorization();
        }
    }
    static class h
    {
        internal static string pathToPhoto;
        internal static string keyName;
        internal static string curVal0;

        public static string ConStr { get; set; }
        public static string typeUser { get; set; }
        public static string nameUser { get; set; }
        public static BindingSource bs1 { get; set; }
        public static DataTable MyfunDt(string commandString)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = new MySqlConnection(h.ConStr))
            {
                MySqlCommand cmd = new MySqlCommand(commandString, con);
                try
                {
                    con.Open();
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            dt.Load(dr);
                        }
                    }
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("Неможливо з'єднатись з SQL-сервером! \nПеревірте наявність Інтернету...",
                        "Помилка з'єднання", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return dt;
        }
        public static string EncriptedPassword(string s)
        {
            if (string.Compare(s, "NULL", true) == 0)
            {
                return "NULL";
            }
            byte[] bytes = Encoding.Unicode.GetBytes(s);
            MD5CryptoServiceProvider CSP = new MD5CryptoServiceProvider();
            byte[] byteHach = CSP.ComputeHash(bytes);
            string hash = string.Empty;
            foreach (byte b in byteHach)
            {
                hash += String.Format("{0:x2}", b);
            }
            return hash;
        }
    }
}