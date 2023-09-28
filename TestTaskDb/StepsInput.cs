using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Spatial;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTaskDb
{
    public partial class StepsInput : Form
    {
        bool operationTypeAdd;
        public StepsInput(bool operationTypeAdd)
        {
            InitializeComponent();
            this.operationTypeAdd = operationTypeAdd;
            if(operationTypeAdd)
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
            if(operationTypeAdd)
            {
                try
                {
                    DataBaseController.Instance.ExcecuteWithQuery(
                        $"INSERT INTO Steps(ModeId, Timer, Destination, Speed, Type, Volume) " +
                        $"VALUES({ModelId.Text}, {Timer.Text}, '{Destination.Text}', {Speed.Text}, '{Type.Text}', {Volume.Text})");
                    MessageBox.Show("step добавлен");
                    this.Close();
                }
                catch(Exception ex)
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
                        $"UPDATE Steps SET" +
                            ((ModelId.Text != "")?$" ModeId = {ModelId.Text} ": " ModeId = ModeId ") + ", " +
                            ((Timer.Text != "") ? $" Timer = {Timer.Text} " : " Timer = Timer ") + ", " +
                            ((Destination.Text != "") ? $" Destination = '{Destination.Text}' " : " Destination =  Destination ") + ", " +
                            ((Speed.Text != "") ? $" Speed = {Speed.Text} " : " Speed = Speed ") + ", " +
                            ((Type.Text != "") ? $" Type = '{Type.Text}' " : " Type = Type ") + ", " +
                            ((Volume.Text != "") ? $" Volume = {Volume.Text} " : " Volume = Volume ") +
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
