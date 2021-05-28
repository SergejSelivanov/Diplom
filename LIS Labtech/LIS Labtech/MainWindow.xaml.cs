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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LIS_Labtech
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
    static class Data
    {
        public static string PositionUser { get; set; }
        public static string LoginUser { get; set; }
        public static string IdUser { get; set; }
    }

    public partial class MainWindow : Window
    {



        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataBaseFunc DBF = new DataBaseFunc();
            DataTable CheckLogPass = DBF.getDataTableFromDB("Users", "Status, Position, id", "`Login`='" + Textbox1.Text + "' AND `Password`='" + Textbox2.Password + "'");

            string Login = Textbox1.Text.Trim();
            string Password = Textbox2.Password.Trim();

            if (CheckLogPass.Rows.Count > 0)
            {
                if (CheckLogPass.Rows[0][0].ToString() != "0")
                {
                    if (CheckLogPass.Rows[0][1].ToString() == "Лаборант")
                    {
                        Data.LoginUser = Textbox1.Text;
                        Data.PositionUser = CheckLogPass.Rows[0][1].ToString();
                        Data.IdUser = CheckLogPass.Rows[0][2].ToString();
                        LaborantWindow LaborantWindow = new LaborantWindow();
                        LaborantWindow.Show();
                        Hide();
                    }
                    else if (CheckLogPass.Rows[0][1].ToString() == "Директор по исследованиям")
                    {
                        Data.LoginUser = Textbox1.Text;
                        Data.PositionUser = CheckLogPass.Rows[0][1].ToString();
                        Data.IdUser = CheckLogPass.Rows[0][2].ToString();
                        DirectorWindow DirectorWindow = new DirectorWindow();
                        DirectorWindow.Show();
                        Hide();
                    }
                    else if (CheckLogPass.Rows[0][1].ToString() == "Менеджер по контролю качества")
                    {
                        Data.LoginUser = Textbox1.Text;
                        Data.PositionUser = CheckLogPass.Rows[0][1].ToString();
                        Data.IdUser = CheckLogPass.Rows[0][2].ToString();
                        ManagerKontrolWindow ManagerKontrolWindow = new ManagerKontrolWindow();
                        ManagerKontrolWindow.Show();
                        Hide();
                    }
                    else if (CheckLogPass.Rows[0][1].ToString() == "Менеджер по закупкам")
                    {
                        Data.LoginUser = Textbox1.Text;
                        Data.PositionUser = CheckLogPass.Rows[0][1].ToString();
                        Data.IdUser = CheckLogPass.Rows[0][2].ToString();
                        ManagerReportWindow ManagerReportWindow = new ManagerReportWindow();
                        ManagerReportWindow.Show();
                        Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Ожидайте подтверждения аккаунта.");
                }

            }
            else
            {
                MessageBox.Show("Такого аккаунта нет в системе.");
            }

            if (Login.Length < 1)
            {
                Textbox1.ToolTip = "Введите логин";
                Textbox1.Background = Brushes.IndianRed;
            }
            else
            {
                Textbox1.ToolTip = null;
                Textbox1.Background = Brushes.Transparent;
            }

            if (Password.Length < 1)
            {
                Textbox2.ToolTip = "Введите пароль";
                Textbox2.Background = Brushes.IndianRed;
            }
            else
            {
                Textbox2.ToolTip = null;
                Textbox2.Background = Brushes.Transparent;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Registration regWindow = new Registration();
            regWindow.Show();
            Hide();
        }
    }
}
