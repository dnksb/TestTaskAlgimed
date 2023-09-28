using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTaskDb
{
    public partial class ModesInput : Form
    {
        bool operationTypeAdd;
        public ModesInput(bool operationTypeAdd)
        {
            InitializeComponent();
            this.operationTypeAdd = operationTypeAdd;
            if (operationTypeAdd)
            {
                button1.Text = "добавить";
            }
            else
            {
                button1.Text = "изменить";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (operationTypeAdd)
            {
                try
                {
                    DataBaseController.Instance.ExcecuteWithQuery(
                        $"INSERT INTO Modes(Name, MaxBottleNumber, MaxUsedTips) " +
                        $"VALUES('{ModeName.Text}', {MaxBottleNumber.Text}, {MaxUsedTips.Text})");
                    MessageBox.Show("mode добавлен");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            else
            {
                try
                {
                    DataBaseController.Instance.ExcecuteWithQuery(
                    $"UPDATE Modes SET" +
                        ((ModeName.Text != "") ? $" Name = '{ModeName.Text}' " : " Name = Name ") + ", " +
                        ((MaxBottleNumber.Text != "") ? $" MaxBottleNumber = {MaxBottleNumber.Text} " : " MaxBottleNumber = MaxBottleNumber ") + ", " +
                        ((MaxUsedTips.Text != "") ? $" MaxUsedTips = {MaxUsedTips.Text} " : " MaxUsedTips =  MaxUsedTips ") +
                        ((ID.Text != "") ? $" WHERE ID = {ID.Text};" : ";"));
                    MessageBox.Show("step добавлен");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
    }
}
