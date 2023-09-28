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
                dataGridView1.Columns.Clear();

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
                numericUpDown1.Maximum = i;
            }
            else if (table == "Steps")
            {
                var Modes = DataBaseController.Instance.ExcecuteWithQuery("SELECT * FROM Steps");

                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

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
                numericUpDown1.Maximum = i;
            }
        }

        private void регистрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registration window = new Registration();
            window.ShowDialog();
            if (DataBaseController.Instance.Auth)
            {
                loadTable("Modes");
            }
        }

        private void авторизацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Authorization window = new Authorization();
            window.ShowDialog();
            if (DataBaseController.Instance.Auth)
            {
                loadTable("Modes");
            }
        }

        private void удалитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!DataBaseController.Instance.Auth)
            {
                MessageBox.Show("вы не авторизиарованы");
                return;
            }
            if (Mode)
            {
                DataBaseController.Instance.ExcecuteNonQuery(
                    $"DELETE FROM Modes WHERE ID = {numericUpDown1.Value}");
                loadTable("Modes");
            }
            else
            {
                DataBaseController.Instance.ExcecuteNonQuery(
                    $"DELETE FROM Steps WHERE ID = {numericUpDown1.Value}");
                loadTable("Steps");
            }

        }

        private void вставитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!DataBaseController.Instance.Auth)
            {
                MessageBox.Show("вы не авторизиарованы");
                return;
            }

            if (Mode)
            {
                ModesInput window = new ModesInput(true);
                window.ShowDialog();
                loadTable("Modes");
            }
            else
            {
                StepsInput window = new StepsInput(true);
                window.ShowDialog();
                loadTable("Steps");
            }
        }

        private void зменитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!DataBaseController.Instance.Auth)
            {
                MessageBox.Show("вы не авторизиарованы");
                return;
            }

            if (Mode)
            {
                ModesInput window = new ModesInput(false);
                window.ShowDialog();
                loadTable("Modes");
            }
            else
            {
                StepsInput window = new StepsInput(false);
                window.ShowDialog();
                loadTable("Steps");
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
