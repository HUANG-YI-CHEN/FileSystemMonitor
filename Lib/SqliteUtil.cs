using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Text;

namespace FileSystemMonitor.Lib
{
    public class SqliteUtil
    {
        public string DatabaseSource { get; set; } = AppDomain.CurrentDomain.BaseDirectory + "sqlite.db";
        private string _connectionString { get; set; }

        public SqliteUtil()
        {
            if (File.Exists(DatabaseSource))
                return;
        }

        public void SetDBSourcePath(string sourcePath)
        {
            if(File.Exists(sourcePath))
                DatabaseSource = sourcePath;
        }

        public void SetConnectString(string connectString)
        {
            _connectionString = connectString;
        }

        public DataTable ExecuteQuery(string queryString)
        {
            if (!File.Exists(DatabaseSource))
                return null;          
            DataTable dt = new DataTable();
            try 
            {
                _connectionString = string.Format("Data Source={0};", DatabaseSource);
                using (var connection = new SQLiteConnection(this._connectionString))
                {
                    connection.Open();      
                    using (SQLiteCommand command = connection.CreateCommand())
                    {
                        command.CommandText = queryString;
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                        adapter.Fill(dt);
                        adapter.Dispose();
                    }
                    connection.Close();
                }
            }
            catch(SQLiteException ex)
            {
                throw ex;
            }  
            return dt;
        }

        public void ExecuteNonQuery(string queryString)
        {
            if (!File.Exists(DatabaseSource))
                return;           
            try
            {
                _connectionString = string.Format("Data Source={0};", DatabaseSource);
                using (var connection = new SQLiteConnection(this._connectionString))
                {
                    connection.Open();
                    using (var transation = connection.BeginTransaction())
                    {
                        try
                        {
                            using (var command = connection.CreateCommand())
                            {
                                command.CommandText = queryString;
                                command.ExecuteNonQuery();
                            }
                            transation.Commit();
                        }
                        catch (SQLiteException ex)
                        {
                            transation.Rollback();
                            throw ex;
                        }
                    }
                    connection.Close();
                }
            }
            catch (SQLiteException ex)
            {
                throw ex;
            }            
        }
    }
}
