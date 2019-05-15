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
    public partial class reg : Form
    {
        SqlConnection ConnectionString = new SqlConnection("Data Source = (Local);Initial Catalog = Demo_ex;Integrated Security = True");

        int b = 0;

        public reg()
        {
            InitializeComponent();
        }

        private void reg_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form lp = new logpas();
            lp.Show();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down)
            {
                textBox2.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                textBox3.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                textBox1.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                textBox3.Focus();
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                textBox4.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                textBox2.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                textBox4.Focus();
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                textBox3.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((textBox3.Text != textBox4.Text) || (textBox3.Text == "" || textBox4.Text == "") || (textBox3.Text == "" && textBox4.Text == ""))
            {
                b++;

                if (b <= 3)
                {
                    MessageBox.Show("Вы не правильно повторили пароль!", "Ошибка");
                    textBox3.Clear();
                    textBox4.Clear();
                }
                else
                {
                    MessageBox.Show("Вы превысили лемит ошибок для регистрации!", "Ошибка");
                    Form lp = new logpas();
                    lp.Show();
                    this.Hide();
                }
               

            }
            else
            {
                ConnectionString.Open();
                try
                {
                    SqlCommand command = new SqlCommand("INSERT INTO Пользователь (Логин,Пароль,Роль,Наименование) VALUES (@Логин,@Пароль,@Роль,@Наименование)", ConnectionString);
                    command.Parameters.AddWithValue("@Логин", textBox2.Text);
                    command.Parameters.AddWithValue("@Пароль", textBox4.Text);
                    command.Parameters.AddWithValue("@Роль", "Заказчик");
                    command.Parameters.AddWithValue("@Наименование", textBox1.Text);
                    int regged = Convert.ToInt32(command.ExecuteNonQuery());
                    MessageBox.Show("Пользователь успешно зарегистрировался!\n");

                    Form lp = new logpas();
                    lp.Show();
                    this.Hide();
                }
                catch
                {
                    b++;

                    if(b<3)
                    {
                        MessageBox.Show("Такой пользователь существует!\n");
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Вы превысили лемит ошибок для регистрации!", "Ошибка");
                        Form lp = new logpas();
                        lp.Show();
                        this.Hide();
                    }

                }

                ConnectionString.Close();
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 15)
            {
                MessageBox.Show("Вы превысили количество символов в textBox1!","Ошибка");
                textBox1.Clear();
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 15)
            {
                MessageBox.Show("Вы превысили количество символов в textBox2!", "Ошибка");
                textBox2.Clear();
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text.Length > 15 || textBox3.Text.Length < 6)
            {
                MessageBox.Show("Вы неверно ввели количество символов в textBox3!", "Ошибка");
                textBox3.Clear();
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text.Length > 15 || textBox4.Text.Length < 6)
            {
                MessageBox.Show("Вы неверно ввели количество символов в textBox4!", "Ошибка");
                textBox4.Clear();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || (e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar == ' ') || (e.KeyChar == '.')) || e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= '0' && e.KeyChar <= '9')) || e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= '0' && e.KeyChar <= '9')) || (e.KeyChar >= '!' && e.KeyChar <= '+') || (e.KeyChar >= ':' && e.KeyChar <= '@') || e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= '0' && e.KeyChar <= '9')) || (e.KeyChar >= '!' && e.KeyChar <= '+') || (e.KeyChar >= ':' && e.KeyChar <= '@') || e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }
    }
}
