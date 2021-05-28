using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для AcountWindow.xaml
    /// </summary>
    public partial class AcountWindow : Window  
    {

        public int flag = 0;
        public int flag1 = 0;
        public int flag2 = 0;
        public int flag3 = 0;
        public int flag4 = 0;
        public int flag5 = 0;
        public int flag6 = 0;
        public string NameAcc;
        public AcountWindow()
        {
            InitializeComponent();



            DataBaseFunc DBF = new DataBaseFunc();
            DataTable CheckLogPass = DBF.getDataTableFromDB("Users", "Login, Password, Email, Telefon, Name, SurName, FatherName", "`id`='" + Data.IdUser + "'");

            if (CheckLogPass.Rows.Count > 0)
            {
                Textbox1.Text = CheckLogPass.Rows[0][0].ToString();
                Textbox1.IsEnabled = false;
                NameAcc = CheckLogPass.Rows[0][0].ToString();
                Textbox2.Password = CheckLogPass.Rows[0][1].ToString();
                Textbox2.IsEnabled = false;
                Textbox4.Text = CheckLogPass.Rows[0][2].ToString();
                Textbox4.IsEnabled = false;
                Textbox5.Text = CheckLogPass.Rows[0][3].ToString();
                Textbox5.IsEnabled = false;
                Textbox6.Text = CheckLogPass.Rows[0][4].ToString();
                Textbox6.IsEnabled = false;
                Textbox7.Text = CheckLogPass.Rows[0][5].ToString();
                Textbox7.IsEnabled = false;
                Textbox8.Text = CheckLogPass.Rows[0][6].ToString();
                Textbox8.IsEnabled = false;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            if (Data.PositionUser == "Лаборант")
            {
                LaborantWindow LaborantWindow = new LaborantWindow();
                LaborantWindow.Show();
                Hide();
            }
            else if (Data.PositionUser == "Директор по исследованиям")
            {
                DirectorWindow DirectorWindow = new DirectorWindow();
                DirectorWindow.Show();
                Hide();
            }
            else if (Data.PositionUser == "Менеджер по контролю качества")
            {
                ManagerKontrolWindow ManagerKontrolWindow = new ManagerKontrolWindow();
                ManagerKontrolWindow.Show();
                Hide();
            }
            else if (Data.PositionUser == "Менеджер по закупкам")
            {
                ManagerReportWindow ManagerReportWindow = new ManagerReportWindow();
                ManagerReportWindow.Show();
                Hide();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (flag == 0)
            {
                Textbox1.IsEnabled = true;
                flag = 1;
            }
            else if (flag == 1)
            {
                DataBaseFunc DBF = new DataBaseFunc();

                DataTable CheckLogPass1 = DBF.getDataTableFromDB("Users", "Login", "`Login`='" + Textbox1.Text + "'");

                if (CheckLogPass1.Rows.Count > 0 && CheckLogPass1.Rows[0][0].ToString() != NameAcc)
                {
                    if (CheckLogPass1.Rows[0][0].ToString() == Textbox1.Text)
                    {
                            MessageBox.Show("Такой логин уже есть в системе");
                    }
                }
                else
                {
                    Textbox1.IsEnabled = false;
                    flag = 0;

                    string tableName = "Users";
                    string setClause = "Login = '" + Textbox1.Text + "'";
                    string whereClause = "id = '" + Data.IdUser + "'";
                    DBF.updateTableFunc(tableName, setClause, whereClause);
                }
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (flag1 == 0)
            {
                Textbox2.IsEnabled = true;
                flag1 = 1;
            }
            else if (flag1 == 1)
            {
                Textbox2.IsEnabled = false;
                flag1 = 0;
                DataBaseFunc DBF = new DataBaseFunc();

                string tableName = "Users";
                string setClause = "Password = '" + Textbox2.Password + "'";
                string whereClause = "id = '" + Data.IdUser + "'";
                DBF.updateTableFunc(tableName, setClause, whereClause);
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (flag2 == 0)
            {
                Textbox4.IsEnabled = true;
                flag2 = 1;
            }
            else if (flag2 == 1)
            {
                Textbox4.IsEnabled = false;
                flag2 = 0;
                DataBaseFunc DBF = new DataBaseFunc();

                string tableName = "Users";
                string setClause = "Email = '" + Textbox4.Text + "'";
                string whereClause = "id = '" + Data.IdUser + "'";
                DBF.updateTableFunc(tableName, setClause, whereClause);
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (flag3 == 0)
            {
                Textbox5.IsEnabled = true;
                flag3 = 1;
            }
            else if (flag3 == 1)
            {
                Textbox5.IsEnabled = false;
                flag3 = 0;
                DataBaseFunc DBF = new DataBaseFunc();

                string tableName = "Users";
                string setClause = "Telefon = '" + Textbox5.Text + "'";
                string whereClause = "id = '" + Data.IdUser + "'";
                DBF.updateTableFunc(tableName, setClause, whereClause);
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (flag4 == 0)
            {
                Textbox6.IsEnabled = true;
                flag4 = 1;
            }
            else if (flag4 == 1)
            {
                Textbox6.IsEnabled = false;
                flag4 = 0;
                DataBaseFunc DBF = new DataBaseFunc();

                string tableName = "Users";
                string setClause = "Name = '" + Textbox6.Text + "'";
                string whereClause = "id = '" + Data.IdUser + "'";
                DBF.updateTableFunc(tableName, setClause, whereClause);
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (flag5 == 0)
            {
                Textbox7.IsEnabled = true;
                flag5 = 1;
            }
            else if (flag5 == 1)
            {
                Textbox7.IsEnabled = false;
                flag5 = 0;
                DataBaseFunc DBF = new DataBaseFunc();

                string tableName = "Users";
                string setClause = "SurName = '" + Textbox7.Text + "'";
                string whereClause = "id = '" + Data.IdUser + "'";
                DBF.updateTableFunc(tableName, setClause, whereClause);
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (flag6 == 0)
            {
                Textbox8.IsEnabled = true;
                flag6 = 1;
            }
            else if (flag6 == 1)
            {
                Textbox8.IsEnabled = false;
                flag6 = 0;
                DataBaseFunc DBF = new DataBaseFunc();

                string tableName = "Users";
                string setClause = "FatherName = '" + Textbox8.Text + "'";
                string whereClause = "id = '" + Data.IdUser + "'";
                DBF.updateTableFunc(tableName, setClause, whereClause);
            }
        }
    }
}
