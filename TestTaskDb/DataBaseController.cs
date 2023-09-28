using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Data.Entity;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace TestTaskDb
{
    internal class DataBaseController
    {
        private static DataBaseController _instance;
        private SQLiteConnection _connection;
        private SQLiteCommand _command;

        private bool auth;

        public static DataBaseController Instance { get => _instance;}

        public bool Auth { get => auth; set => auth = value; }

        public static void setInstance()
        {
            if (_instance == null)
                _instance = new DataBaseController();
        }

        private DataBaseController()
        {
            _instance = this;
            auth = false;
            createConnection();
            createTables();
        }

        private void createConnection()
        {
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

        private void createTables()
        {
            string Createsql =
                "CREATE TABLE Users (ID INTEGER PRIMARY KEY AUTOINCREMENT, Username VARCHAR(25) UNIQUE, Password VARCHAR(25));";
            _command = _connection.CreateCommand();
            _command.CommandText = Createsql;
            try
            {
                _command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }

            Createsql = 
                "CREATE TABLE Modes (ID INTEGER PRIMARY KEY AUTOINCREMENT, Name VARCHAR(25), MaxBottleNumber INTEGER, MaxUsedTips INTEGER);";
            _command = _connection.CreateCommand();
            _command.CommandText = Createsql;
            try
            {
                _command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {

            }

            Createsql =
                "CREATE TABLE Steps (ID INTEGER PRIMARY KEY AUTOINCREMENT, ModeId INTEGER, Timer INTEGER DEFAULT 0, Destination  VARCHAR(25), Speed INTEGER, Type  VARCHAR(25), Volume INTEGER,  FOREIGN KEY (ModeId)  REFERENCES Modes (ID));";
            _command = _connection.CreateCommand();
            _command.CommandText = Createsql;
            try
            {
                _command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
        }

        public void ExcecuteNonQuery(string query)
        {
            _command = _connection.CreateCommand();
            _command.CommandText = query;
            _command.ExecuteNonQuery();
        }

        public SQLiteDataReader ExcecuteWithQuery(string query)
        {
            _command = _connection.CreateCommand();
            _command.CommandText = query;
            return _command.ExecuteReader();
        }
    }
}
