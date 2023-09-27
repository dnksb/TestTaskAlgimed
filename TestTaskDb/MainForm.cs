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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void регистрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registration window = new Registration();
            window.ShowDialog();
        }

        private void авторизацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Authorization window = new Authorization();
            window.ShowDialog();
        }

        private void удалитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void вставитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void зменитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void импортExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stepsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
