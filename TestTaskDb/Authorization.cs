using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTaskDb
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if (username == "" || password == "")
            {
                MessageBox.Show("неправильное введен логин или пароль");
                return;
            }

            Regex reg = new Regex("(?=.*[A-Za-z])(?=.*\\d)[A-Za-z\\d]{6,}");

            if (!reg.IsMatch(password))
            {
                MessageBox.Show("пароль не подходит\nдолжен быть длинее 6 символов\nиметь одну букву и цифру");
                return;
            }

            try
            {
                var User = DataBaseController.Instance.ExcecuteWithQuery($"SELECT Username FROM Users WHERE Username = '{username}' AND Password = '{password.GetHashCode()}';");
                while (User.Read())
                {
                    if(User.GetString(0) == username)
                    {
                        DataBaseController.Instance.Auth = true;
                        this.Close();
                        return;
                    }
                }
                MessageBox.Show("пользователь не найден");
            }
            catch (Exception ex)
            {
                MessageBox.Show("пользователь не найден");
            }
        }
    }
}
