using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Demoexzamin
{
    public partial class logpas : Form
    {
        SqlConnection ConnectionString = new SqlConnection("Data Source = (Local);Initial Catalog = Demo_ex;Integrated Security = True");

        int b = 0;

        public logpas()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Red;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form r = new reg();
            r.Show();
            this.Hide();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down)
            {
                textBox2.Focus();
            }
            if(e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                textBox1.Focus();

            }
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            ConnectionString.Open();

            String login = textBox1.Text;
            String pass = textBox2.Text;

            SqlCommand command = new SqlCommand("SELECT * FROM Пользователь WHERE Логин = '" + login + "' AND Пароль = '" + pass + "'", ConnectionString);
            SqlDataReader reader = command.ExecuteReader();

            String role = "", name = "";

            while (reader.Read())
            {

                role = reader[2].ToString();
                name = reader[3].ToString();
            }

            switch (role)
            {
                case "Заказчик":
                    Form z = new Zakazchik();
                    this.Hide();
                    z.Show();
                    break;

                case "Администратор":
                    Form a = new admin();
                    this.Hide();
                    a.Show();
                    break;

                case "Кладовщик":
                    Form k = new kladovchik();
                    this.Hide();
                    k.Show();
                    break;

                case "Менеджер":
                    Form m = new meneger();
                    this.Hide();
                    m.Show();
                    break;

                default:

                    b++;

                    if(b <= 3)
                    {
                        MessageBox.Show("Роль не установлена или пользователь не найден!","Ошибка");
                        textBox1.Clear();
                        textBox2.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Вы превысили лемит ошибок для авторизации!","Ошибка");
                        Application.ExitThread();
                    }

                    
                    break;
            }

            ConnectionString.Close();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 15)
            {
                MessageBox.Show("Вы ввели больше положенного в textbox1!","Ошибка");
                textBox1.Clear();
            }

            if (textBox1.Text.Length < 1 && textBox2.Text.Length < 15)
            {
                MessageBox.Show("Нельзя вводить логин без пароля!","Помощь");
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 15)
            {
                MessageBox.Show("Вы ввели больше положенного в textbox2!", "Ошибка");
                textBox2.Clear();
            }

            if (textBox2.Text.Length < 1 && textBox1.Text.Length < 15)
            {
                MessageBox.Show("Нельзя вводить пароль без логина!","Помощь");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= '0' && e.KeyChar <= '9')) || e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= '0' && e.KeyChar <= '9')) || (e.KeyChar >= '!' && e.KeyChar <= '+') || (e.KeyChar >= ':' && e.KeyChar <= '@') || e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }
    }
}
