using Npgsql;
using System.Data;

namespace TemplateApp
{
    public class DbContext
    {
        private readonly NpgsqlConnection connection = new NpgsqlConnection();
        public DbContext() { }
        public DbContext(NpgsqlConnectionStringBuilder build) 
        {
            connection.ConnectionString = build.ConnectionString;
        }

        public void AddRow(DataRow row, string table)
        {
            connection.Open();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter($"SELECT * FROM {table}", connection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            DataTable dataTable = dataSet.Tables[0];
            DataRow row2 = dataTable.NewRow();

            for(int i = 0; i < dataTable.Columns.Count; i++)
            {
                row2[i] = row[i];
            }

            dataTable.Rows.Add(row2);

            NpgsqlCommandBuilder builder = new NpgsqlCommandBuilder(adapter);
            adapter.Update(dataSet);
            connection.Close();
        }

        public DataTable GetTable(string table)
        {
            connection.Open();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter($"SELECT * FROM {table}", connection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            connection.Close();
            return dataSet.Tables[0];
        }

        public DataRow GetByKey(object key, string table)
        {
            connection.Open();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter($"SELECT * FROM {table}", connection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            DataTable dataTable = dataSet.Tables[0];
            DataRow row = null;

            foreach (DataRow i in dataTable.Rows)
            {
                if (i[0].ToString() == key.ToString())
                {
                    row = i;
                    break;
                }
            }
            connection.Close();
            return row;
        }

        public void DeleteRow(DataRow row, string table)
        {
            connection.Open();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter($"SELECT * FROM {table}", connection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            DataTable dataTable = dataSet.Tables[0];
            DataRow row2 = null;

            foreach(DataRow i in dataTable.Rows)
            {
                if (i[0].ToString() == row[0].ToString())
                {
                    row2 = i;
                    break;
                }
            }
            if (row2 == null)
            {
                connection.Close();
                return;
            }
            row2.Delete();

            NpgsqlCommandBuilder builder = new NpgsqlCommandBuilder(adapter);
            adapter.Update(dataSet);
            connection.Close();
        }

        public bool Update(DataRow beforeRow, DataRow afterRow, string table)
        {
            connection.Open();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter($"SELECT * FROM {table}", connection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            DataTable dataTable = dataSet.Tables[0];
            DataRow row = null;

            foreach (DataRow i in dataTable.Rows)
            {
                if (i[0].ToString() == beforeRow[0].ToString())
                {
                    row = i;
                    break;
                }
            }

            if(row == null)
            {
                connection.Close();
                return false;
            }

            for(int i = 0; i < dataTable.Columns.Count; i++)
                row[i] = afterRow[i];

            NpgsqlCommandBuilder builder = new NpgsqlCommandBuilder(adapter);
            adapter.Update(dataSet);
            connection.Close();
            return true;
        }
    }
}
