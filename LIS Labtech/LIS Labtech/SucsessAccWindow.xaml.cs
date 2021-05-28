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
    /// Логика взаимодействия для SucsessAccWindow.xaml
    /// </summary>

    static class AccActive
    {
        public static string PositionUser { get; set; }
        public static string LoginUser { get; set; }
        public static string IdUser { get; set; }
        public static string StatusUser { get; set; }
    }

    public partial class SucsessAccWindow : Window
    {
        public SucsessAccWindow()
        {
            InitializeComponent();
            LoadUsers();
            LoadUsers1();
        }

        void LoadUsers()
        {
            DataBaseFunc DBF = new DataBaseFunc();
            DataTable CheckLogPass = DBF.getDataTableFromDB("Users", "Name, SurName, FatherName, Telefon, Position, Login", "`Status`='" + "0" + "'");
            for (int i = 0; i < CheckLogPass.Rows.Count; i++) // перебираем данные  
            {
                DataBaseFunc.user dataUser = new DataBaseFunc.user() // создаём экземпляр класса        
                {
                    Name = CheckLogPass.Rows[i][0].ToString(), // указываем изображение из таблицы    
                    SurName = CheckLogPass.Rows[i][1].ToString(), // указываем логин         
                    FatherName = CheckLogPass.Rows[i][2].ToString(), // казываем пароль     
                    Telefon = CheckLogPass.Rows[i][3].ToString(), // казываем пароль     
                    Position = CheckLogPass.Rows[i][4].ToString(), // казываем пароль     
                    Login = CheckLogPass.Rows[i][5].ToString() // казываем пароль     
                };
                listUsers.Items.Add(dataUser); // выводим строку в список 
            }
        }

        void LoadUsers1()
        {
            DataBaseFunc DBF = new DataBaseFunc();
            DataTable CheckLogPass = DBF.getDataTableFromDB("Users", "Name, SurName, FatherName, Telefon, Position, Login", "`Status`='" + "1" + "'");
            for (int i = 0; i < CheckLogPass.Rows.Count; i++) // перебираем данные  
            {
                DataBaseFunc.user dataUser = new DataBaseFunc.user() // создаём экземпляр класса        
                {
                    Name = CheckLogPass.Rows[i][0].ToString(), // указываем изображение из таблицы    
                    SurName = CheckLogPass.Rows[i][1].ToString(), // указываем логин         
                    FatherName = CheckLogPass.Rows[i][2].ToString(), // казываем пароль     
                    Telefon = CheckLogPass.Rows[i][3].ToString(), // казываем пароль     
                    Position = CheckLogPass.Rows[i][4].ToString(), // казываем пароль
                    Login = CheckLogPass.Rows[i][5].ToString() // казываем пароль     
                };
                listUsers1.Items.Add(dataUser); // выводим строку в список 
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DirectorWindow DirectorWindow = new DirectorWindow();
            DirectorWindow.Show();
            Hide();
        }

        private void listUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataBaseFunc DBF = new DataBaseFunc();
            DataBaseFunc.user firstItem = e.AddedItems[0] as DataBaseFunc.user;    // cast..
            if (firstItem != null)                                          // if not null..
            {
                AccActive.LoginUser = firstItem.Login;
                AccOnOffWindow AccOnOffWindow = new AccOnOffWindow(0);
                AccOnOffWindow.Show();
                Hide();
            }
        }

        private void listUsers1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataBaseFunc DBF = new DataBaseFunc();
            DataBaseFunc.user firstItem = e.AddedItems[0] as DataBaseFunc.user;    // cast..
            if (firstItem != null)                                          // if not null..
            {
                AccActive.LoginUser = firstItem.Login;
                AccOnOffWindow AccOnOffWindow = new AccOnOffWindow(1);
                AccOnOffWindow.Show();
                Hide();
            }
        }
    }
}
