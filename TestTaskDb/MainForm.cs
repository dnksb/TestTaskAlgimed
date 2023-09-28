using Microsoft.Office.Interop.Excel;
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
using Excel = Microsoft.Office.Interop.Excel;

namespace TestTaskDb
{
    public partial class MainForm : Form
    {
        private bool Mode;
        private Excel.Application excelapp;
        private Excel.Workbooks excelappworkbooks;
        private Excel.Workbook excelappworkbook;
        private Excel.Sheets excelsheets;
        private Excel.Worksheet excelworksheet;
        private Excel.Range excelcells;
        public MainForm()
        {
            Mode = true;
            InitializeComponent();
        }

        void loadTable(string table)
        {
            //если таблица Modes активная
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
            //если таблица Steps активная
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

        void insertIntoModes(int num)
        {
            string MaxBottleNumberExcel;
            string MaxUsedTipsExcel;
            string NameExcel;
            // получаем значения из таблицы
            excelcells = excelworksheet.get_Range("B" + num.ToString(), Type.Missing);
            NameExcel = Convert.ToString(excelcells.Value2);
            excelcells = excelworksheet.get_Range("C" + num.ToString(), Type.Missing);
            MaxBottleNumberExcel = Convert.ToString(excelcells.Value2);
            excelcells = excelworksheet.get_Range("D" + num.ToString(), Type.Missing);
            MaxUsedTipsExcel = Convert.ToString(excelcells.Value2);

            DataBaseController.Instance.ExcecuteWithQuery(
                $"INSERT INTO Modes(Name, MaxBottleNumber, MaxUsedTips) " +
                $"VALUES('{NameExcel}', {MaxBottleNumberExcel}, {MaxUsedTipsExcel})");
        }

        void insertIntoSteps(int num)
        {
            string ModeIdExcel;
            string TimerExcel;
            string DestinationExcel;
            string SpeedExcel;
            string TypeExcel;
            string VolumeExcel;
            // получаем значения из таблицы
            excelcells = excelworksheet.get_Range("B" + num.ToString(), Type.Missing);
            ModeIdExcel = Convert.ToString(excelcells.Value2);
            excelcells = excelworksheet.get_Range("C" + num.ToString(), Type.Missing);
            TimerExcel = Convert.ToString(excelcells.Value2);
            excelcells = excelworksheet.get_Range("D" + num.ToString(), Type.Missing);
            DestinationExcel = Convert.ToString(excelcells.Value2);
            excelcells = excelworksheet.get_Range("E" + num.ToString(), Type.Missing);
            SpeedExcel = Convert.ToString(excelcells.Value2);
            excelcells = excelworksheet.get_Range("F" + num.ToString(), Type.Missing);
            TypeExcel = Convert.ToString(excelcells.Value2);
            excelcells = excelworksheet.get_Range("G" + num.ToString(), Type.Missing);
            VolumeExcel = Convert.ToString(excelcells.Value2);

            DataBaseController.Instance.ExcecuteWithQuery(
                         $"INSERT INTO Steps(ModeId, Timer, Destination, Speed, Type, Volume) " +
            $"VALUES({ModeIdExcel}, {TimerExcel}, '{DestinationExcel}', {SpeedExcel}, '{TypeExcel}', {VolumeExcel})");
        }

        private void импортExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!DataBaseController.Instance.Auth)
            {
                MessageBox.Show("вы не авторизиарованы");
                return;
            }
            
            //выбираем файл для чтения
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            
            //открываем excel
            excelapp = new Excel.Application();
            excelapp.Visible = true;
            excelappworkbooks = excelapp.Workbooks;
            //открываем книгу и получаем на нее ссылку
            excelappworkbook = excelapp.Workbooks.Open(openFileDialog1.FileName,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing);
            excelsheets = excelappworkbook.Worksheets;
            //получаем ссылку на лист Modes
            excelworksheet = (Excel.Worksheet)excelsheets.get_Item(1);
            //записываем все из листа Modes
            for (int i = 2; i < excelworksheet.Rows.Count; i++)
            {
                excelcells = excelworksheet.get_Range("B" + i.ToString(), Type.Missing);
                if (excelcells.Value2 == null)
                    break;

                insertIntoModes(i);
            }
            //получаем ссылку на лист Steps
            excelworksheet = (Excel.Worksheet)excelsheets.get_Item(2);
            //записываем все из листа Steps
            for (int i = 2; i < excelworksheet.Rows.Count; i++)
            {
                excelcells = excelworksheet.get_Range("B" + i.ToString(), Type.Missing);
                if (excelcells.Value2 == null)
                    break;

                insertIntoSteps(i);
            }
            excelapp.Quit();
            if (Mode)
                loadTable("Modes");
            else
                loadTable("Steps");
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
