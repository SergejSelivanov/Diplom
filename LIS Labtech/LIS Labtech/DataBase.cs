using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LIS_Labtech
{
    class DataBase
    {
        MySqlConnection connstr = new MySqlConnection("server=31.31.196.201; port=3306; username=u1378304_default; password=22qbzYvF0xzRF4GC; database=u1378304_lislabtech; charset=utf8");

        public void openConnection(MySqlConnection dbs)
        {
            if (dbs.State == System.Data.ConnectionState.Closed)
                dbs.Open();
        }
        public void closeConnection(MySqlConnection dbs)
        {
            if (dbs.State == System.Data.ConnectionState.Open)
                dbs.Close();
        }

        public MySqlConnection getConnection()
        {
            try
            {
                openConnection(connstr);
                return connstr;
            }
            catch
            {
                MessageBox.Show("Нет подключения к сети!");
                return null;
            }
        }
    }
}
