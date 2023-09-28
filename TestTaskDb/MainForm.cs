using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTaskDb
{
    public partial class MainForm : Form
    {
        private bool Mode;
        public MainForm()
        {
            Mode = true;
            InitializeComponent();
        }

        void loadTable(string table)
        {
            if(table == "Modes")
            {
                var Modes = DataBaseController.Instance.ExcecuteWithQuery("SELECT * FROM Modes");
                
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Add("ID", "ID");
                dataGridView1.Columns.Add("Name", "Name");
                dataGridView1.Columns.Add("MaxBottleNumber", "MaxBottleNumber");
                dataGridView1.Columns.Add("MaxUsedTips", "MaxUsedTips");

                int i = 0;
                while(Modes.Read())
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = Modes.GetInt32(0);
                    dataGridView1.Rows[i].Cells[1].Value = Modes.GetString(1);
                    dataGridView1.Rows[i].Cells[2].Value = Modes.GetInt32(2);
                    dataGridView1.Rows[i].Cells[3].Value = Modes.GetInt32(3);
                    i++;
                }
            }
            else if (table == "Steps")
            {
                var Modes = DataBaseController.Instance.ExcecuteWithQuery("SELECT * FROM Steps");

                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Add("ID", "ID");
                dataGridView1.Columns.Add("ModeId", "ModeId");
                dataGridView1.Columns.Add("Timer", "Timer");
                dataGridView1.Columns.Add("Destination", "Destination");
                dataGridView1.Columns.Add("Speed", "Speed");
                dataGridView1.Columns.Add("Type", "Type");
                dataGridView1.Columns.Add("Volume", "Volume");

                int i = 0;
                while (Modes.Read())
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = Modes.GetInt32(0);
                    dataGridView1.Rows[i].Cells[1].Value = Modes.GetInt32(1);
                    dataGridView1.Rows[i].Cells[2].Value = Modes.GetInt32(2);
                    dataGridView1.Rows[i].Cells[3].Value = Modes.GetString(3);
                    dataGridView1.Rows[i].Cells[4].Value = Modes.GetInt32(4);
                    dataGridView1.Rows[i].Cells[5].Value = Modes.GetString(5);
                    dataGridView1.Rows[i].Cells[6].Value = Modes.GetInt32(6);
                    i++;
                }
            }
        }

        private void регистрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registration window = new Registration();
            window.ShowDialog();
            loadTable("Modes");
        }

        private void авторизацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Authorization window = new Authorization();
            window.ShowDialog();
            loadTable("Modes");
        }

        private void удалитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!DataBaseController.Instance.Auth)
            {
                MessageBox.Show("вы не авторизиарованы");
                return;
            }
        }

        private void вставитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!DataBaseController.Instance.Auth)
            {
                MessageBox.Show("вы не авторизиарованы");
                return;
            }
        }

        private void зменитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!DataBaseController.Instance.Auth)
            {
                MessageBox.Show("вы не авторизиарованы");
                return;
            }
        }

        private void импортExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!DataBaseController.Instance.Auth)
            {
                MessageBox.Show("вы не авторизиарованы");
                return;
            }
        }

        private void modesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!DataBaseController.Instance.Auth)
            {
                MessageBox.Show("вы не авторизиарованы");
                return;
            }
            loadTable("Modes");
            Mode = true;
        }

        private void stepsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!DataBaseController.Instance.Auth)
            {
                MessageBox.Show("вы не авторизиарованы");
                return;
            }
            loadTable("Steps");
            Mode = false;
        }
    }
}
