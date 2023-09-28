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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if(username == "" || password == "")
            {
                MessageBox.Show("неправильное введен логин или пароль");
                return;
            }

            Regex reg = new Regex("(?=.*[A-Za-z])(?=.*\\d)[A-Za-z\\d]{6,}");

            if(!reg.IsMatch(password))
            {
                MessageBox.Show("пароль не подходит\nдолжен быть длинее 6 символов\nиметь одну букву и цифру");
                return;
            }

            try
            {
                DataBaseController.Instance.ExcecuteWithQuery($"INSERT INTO Users(Username, Password) VALUES('{username}', '{password.GetHashCode()}')");
                DataBaseController.Instance.Auth = true;
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("такой пользователь уже создан");
            }
        }
    }
}
