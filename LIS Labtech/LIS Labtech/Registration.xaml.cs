using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataBaseFunc DBF = new DataBaseFunc();

            DataTable CheckLogPass = DBF.getDataTableFromDB("Users", "Login", "`Login`='" + Textbox1.Text + "'");

            string Login = Textbox1.Text.Trim();
            string Password = Textbox2.Password.Trim();
            string Passwordch = Textbox3.Password.Trim();
            string Email = Textbox4.Text.Trim();
            string Telefon = Textbox5.Text.Trim();
            string Name = Textbox6.Text.Trim().ToLower();
            string SurName = Textbox7.Text.Trim().ToLower();
            string FatherName = Textbox8.Text.Trim().ToLower();
            string Position = CombBox9.Text.Trim();
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");
            var hasOnly11Number = new Regex(@"^[0-9]{11}$");
            var hasOnlyEChar = new Regex(@"^[A-Z]$");
            var hasOnlyRChar = new Regex(@"^[а-я]");
            int flag = 0;

            if (Login.Length < 1)
            {
                flag = 1;
                Textbox1.ToolTip = "Введите логин";
                Textbox1.Background = Brushes.IndianRed;
            }
            else
            {
                Textbox1.ToolTip = null;
                Textbox1.Background = Brushes.Transparent;
            }

            if (CheckLogPass.Rows.Count > 0)
            {
                if (CheckLogPass.Rows[0][0].ToString() == Textbox1.Text)
                {
                    flag = 1;
                    Textbox1.ToolTip = "Такой логин уже имеется в системе";
                    Textbox1.Background = Brushes.IndianRed;
                }
                else
                {
                    Textbox1.ToolTip = null;
                    Textbox1.Background = Brushes.Transparent;
                }
            }

            if (!(hasNumber.IsMatch(Password) && hasUpperChar.IsMatch(Password) && hasMinimum8Chars.IsMatch(Password)))
            {
                flag = 1;
                Textbox2.ToolTip = "Пароль должен иметь:\n 1) Больше 8 цифр\n 2) Заглавные буквы\n 3) Цифры\n 4) Только латинские буквы";
                Textbox2.Background = Brushes.IndianRed;
            }
            else
            {
                Textbox2.ToolTip = null;
                Textbox2.Background = Brushes.Transparent;
            }

            if (Passwordch != Password)
            {
                flag = 1;
                Textbox3.ToolTip = "Пароли не совпадают";
                Textbox3.Background = Brushes.IndianRed;
            }
            else
            {
                Textbox3.ToolTip = null;
                Textbox3.Background = Brushes.Transparent;
            }

            if (!Email.Contains("@") && !Email.Contains("."))
            {
                flag = 1;
                Textbox4.ToolTip = "Email введен некоректно";
                Textbox4.Background = Brushes.IndianRed;
            }
            else
            {
                Textbox4.ToolTip = null;
                Textbox4.Background = Brushes.Transparent;
            }

            if (!(hasOnly11Number.IsMatch(Telefon)))
            {
                flag = 1;
                Textbox5.ToolTip = "Телефон состоит только из 11 цифр\nПример:\n89163233333";
                Textbox5.Background = Brushes.IndianRed;
            }
            else
            {
                Textbox5.ToolTip = null;
                Textbox5.Background = Brushes.Transparent;
            }

            if (!(hasOnlyRChar.IsMatch(Name)))
            {
                flag = 1;
                Textbox6.ToolTip = "Имя может состоять только из русских букв";
                Textbox6.Background = Brushes.IndianRed;
            }
            else
            {
                Textbox6.ToolTip = null;
                Textbox6.Background = Brushes.Transparent;
            }

            if (!(hasOnlyRChar.IsMatch(SurName)))
            {
                flag = 1;
                Textbox7.ToolTip = "Фамилия может состоять только из русских букв";
                Textbox7.Background = Brushes.IndianRed;
            }
            else
            {
                Textbox7.ToolTip = null;
                Textbox7.Background = Brushes.Transparent;
            }

            if (!(hasOnlyRChar.IsMatch(FatherName)))
            {
                flag = 1;
                Textbox8.ToolTip = "Отчество может состоять только из русских букв";
                Textbox8.Background = Brushes.IndianRed;
            }
            else
            {
                Textbox8.ToolTip = null;
                Textbox8.Background = Brushes.Transparent;
            }

            if (Position.Length < 1)
            {
                flag = 1;
                CombBox9.ToolTip = "Выберите должность из списка";
                CombBox9.Background = Brushes.IndianRed;
            }
            else
            {
                CombBox9.ToolTip = null;
                CombBox9.Background = Brushes.Transparent;
            }
            if (flag == 0)
            {
                string tableName = "Users";
                string columnsName = "Login, Password, Email, Telefon, Name, SurName, FatherName, Position";
                string values = "'" + Textbox1.Text + "', '" + Textbox2.Password + "', '" + Textbox4.Text + "', '" + Textbox5.Text + "', '" +
                  Textbox6.Text + "', '" + Textbox7.Text + "', '" + Textbox8.Text + "', '" + CombBox9.Text + "'";
                DBF.insertIntoTableFunc(tableName, columnsName, values);

                MessageBox.Show("Ваша заявка отправлена.");
                this.Close();
                MainWindow MainWindow = new MainWindow();
                MainWindow.Show();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Hide();
        }
    }
}
