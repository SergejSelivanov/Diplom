using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIS_Labtech
{
    class DataBaseFunc
    {
        public class user
        {
            public string Name { get; set; }
            public string SurName { get; set; }
            public string FatherName { get; set; }
            public string Position { get; set; }
            public string Telefon { get; set; }
            public string Login { get; set; }
        }

        public class educ
        {
            public string Name { get; set; }
        }

        public DataTable getDataTableFromDB(string NamesOfTable, string NamesOfColumns, string Condition)
        {
            DataBase db = new DataBase();
            MySqlConnection dbc = db.getConnection();

            if (dbc != null)
            {
                db.openConnection(dbc);

                DataTable ValueTable = new DataTable();
                MySqlDataAdapter ValueAdapter = new MySqlDataAdapter();

                MySqlCommand ValueCommand = new MySqlCommand("SELECT " + @NamesOfColumns + " FROM " + @NamesOfTable + " WHERE " + @Condition, dbc);
                ValueCommand.Parameters.Add("@tableName", MySqlDbType.VarChar).Value = NamesOfTable;
                ValueCommand.Parameters.Add("@columnsName", MySqlDbType.VarChar).Value = NamesOfColumns;
                ValueCommand.Parameters.Add("@whereClause", MySqlDbType.VarChar).Value = Condition;

                ValueAdapter.SelectCommand = ValueCommand;
                ValueAdapter.Fill(ValueTable);

                db.closeConnection(dbc);

                return ValueTable;
            }
            return null;
        }

        public DataTable getDataTableFromDBwithoutWhere(string NamesOfTable, string NamesOfColumns)
        {
            DataBase db = new DataBase();
            MySqlConnection dbc = db.getConnection();

            if (dbc != null)
            {
                db.openConnection(dbc);

                DataTable ValueTable = new DataTable();
                MySqlDataAdapter ValueAdapter = new MySqlDataAdapter();

                MySqlCommand ValueCommand = new MySqlCommand("SELECT " + @NamesOfColumns + " FROM " + @NamesOfTable, dbc);
                ValueCommand.Parameters.Add("@tableName", MySqlDbType.VarChar).Value = NamesOfTable;
                ValueCommand.Parameters.Add("@columnsName", MySqlDbType.VarChar).Value = NamesOfColumns;

                ValueAdapter.SelectCommand = ValueCommand;
                ValueAdapter.Fill(ValueTable);

                db.closeConnection(dbc);

                return ValueTable;
            }
            return null;
        }

        public DataTable ExecuteSql(string sql)
        {
            DataTable dt = new DataTable();
            MySqlConnection conn = new MySqlConnection(
                "server=31.31.196.201; port=3306; username=u1378304_default; password=22qbzYvF0xzRF4GC; database=u1378304_lislabtech; charset=utf8"
                );

            using (conn)
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader read = cmd.ExecuteReader();

                using (read)
                {
                    dt.Load(read);
                }
            }

            return dt;
        }

        public int insertIntoTableFunc(string tableName, string columnsName, string values)
        {
            DataBase db = new DataBase();
            MySqlConnection dbc = db.getConnection();

            if (dbc == null)
            {
                return 1;
            }
            else
            {
                db.openConnection(dbc);

                MySqlCommand commandInsertIntoTable = new MySqlCommand("INSERT INTO " + @tableName + " (" + @columnsName + " ) VALUES (" + @values + ")", dbc);
                commandInsertIntoTable.Parameters.Add("@tableName", MySqlDbType.VarChar).Value = tableName;
                commandInsertIntoTable.Parameters.Add("@columnsName", MySqlDbType.VarChar).Value = columnsName;
                commandInsertIntoTable.Parameters.Add("@valuesName", MySqlDbType.VarChar).Value = values;

                commandInsertIntoTable.ExecuteNonQuery();
                db.closeConnection(dbc);

                return 0;
            }
        }

        public int updateTableFunc(string tableName, string setClause, string whereClause)
        {
            DataBase db = new DataBase();
            MySqlConnection dbc = db.getConnection();

            if (dbc == null)
            {
                return 1;
            }
            else
            {
                db.openConnection(dbc);

                MySqlCommand commandInsertIntoTable = new MySqlCommand("UPDATE " + @tableName + " SET " + @setClause + " WHERE " + @whereClause, dbc);
                commandInsertIntoTable.Parameters.Add("@tableName", MySqlDbType.VarChar).Value = tableName;
                commandInsertIntoTable.Parameters.Add("@setClause", MySqlDbType.VarChar).Value = setClause;
                commandInsertIntoTable.Parameters.Add("@whereClause", MySqlDbType.VarChar).Value = whereClause;

                commandInsertIntoTable.ExecuteNonQuery();
                db.closeConnection(dbc);

                return 0;
            }
        }
    }
}
