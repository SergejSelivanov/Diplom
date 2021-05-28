using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LIS_Labtech
{
    /// <summary>
    /// Логика взаимодействия для AccOnOffWindow.xaml
    /// </summary>
    public partial class AccOnOffWindow : Window
    {
        public int statususer;
        public AccOnOffWindow(int status)
        {
            InitializeComponent();
            statususer = status;
            if (statususer == 0)
            {
                buttonOff.IsEnabled = false;
            }
            else if (statususer == 1)
            {
                buttonOn.IsEnabled = false;
            }
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            SucsessAccWindow SucsessAccWindow = new SucsessAccWindow();
            SucsessAccWindow.Show();
            Hide();
        }

        private void buttonOn_Click(object sender, RoutedEventArgs e)
        {
            DataBaseFunc DBF = new DataBaseFunc();

            string tableName = "Users";
            string setClause = "Status = '" + "1" + "'";
            string whereClause = "Login = '" + AccActive.LoginUser + "'";
            DBF.updateTableFunc(tableName, setClause, whereClause);
            buttonOn.IsEnabled = false;
            buttonOff.IsEnabled = true;
            statususer = 1;
        }

        private void buttonOff_Click(object sender, RoutedEventArgs e)
        {
            DataBaseFunc DBF = new DataBaseFunc();

            string tableName = "Users";
            string setClause = "Status = '" + "0" + "'";
            string whereClause = "Login = '" + AccActive.LoginUser + "'";
            DBF.updateTableFunc(tableName, setClause, whereClause);
            buttonOn.IsEnabled = true;
            buttonOff.IsEnabled = false;
            statususer = 0;
        }
    }
}
