using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Data.Entity;
using System.Windows.Forms;

namespace TestTaskDb
{
    internal class DataBaseController
    {
        public static DataBaseController _instance;
        private SQLiteConnection _connection;
        private SQLiteCommand _command;
        private SQLiteDataReader _reader;
        private SQLiteDataReader _writer;

        public static void setInstance()
        {
            if (_instance == null)
                _instance = new DataBaseController();
        }

        public DataBaseController()
        {
            _instance = this;
            _connection = new SQLiteConnection("Data Source=database.db; Version = 3; New = True; Compress = True; ");
            try
            {
                _connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
