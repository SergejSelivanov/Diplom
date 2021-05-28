using MySql.Data.MySqlClient;
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
    /// Логика взаимодействия для EducGetPage.xaml
    /// </summary>
    public class EducRes
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string FatherName { get; set; }
        public string NameEduc { get; set; }
        public string Result { get; set; }
        public string Login { get; set; }
    }

    public partial class EducGetPage : Page
    {
        public EducGetPage()
        {
            InitializeComponent();
            EducLoad();
        }

        void EducLoad()
        {
            DataBase db = new DataBase();
            MySqlConnection dbc = db.getConnection();

            if (dbc != null)
            {
                db.openConnection(dbc);

                DataTable ValueTable = new DataTable();
                MySqlDataAdapter ValueAdapter = new MySqlDataAdapter();

                MySqlCommand ValueCommand = new MySqlCommand("SELECT d.Login, d.Name, d.SurName, d.FatherName, t.Name, p.Result FROM `NaznEduc` p INNER JOIN `Users` d ON p.idUser = d.id INNER JOIN `Education` t ON p.idEduc = t.id WHERE p.Result >= '0'", dbc);

                ValueAdapter.SelectCommand = ValueCommand;
                ValueAdapter.Fill(ValueTable);

                db.closeConnection(dbc);

                for (int i = 0; i < ValueTable.Rows.Count; i++) // перебираем данные  
                {
                    EducRes dataUser = new EducRes() // создаём экземпляр класса        
                    {
                        Name = ValueTable.Rows[i][1].ToString(), // указываем изображение из таблицы    
                        SurName = ValueTable.Rows[i][2].ToString(), // указываем логин         
                        FatherName = ValueTable.Rows[i][3].ToString(), // казываем пароль     
                        NameEduc = ValueTable.Rows[i][4].ToString(), // казываем пароль     
                        Result = ValueTable.Rows[i][5].ToString(), // казываем пароль     
                        Login = ValueTable.Rows[i][0].ToString() // казываем пароль     
                    };
                    listUsers.Items.Add(dataUser); // выводим строку в список 
                }
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            listUsers.Items.Clear();
            DataBase db = new DataBase();
            MySqlConnection dbc = db.getConnection();

            if (dbc != null)
            {
                db.openConnection(dbc);

                DataTable ValueTable = new DataTable();
                MySqlDataAdapter ValueAdapter = new MySqlDataAdapter();

                MySqlCommand ValueCommand = new MySqlCommand("SELECT d.Login, d.Name, d.SurName, d.FatherName, t.Name, p.Result FROM `NaznEduc` p INNER JOIN `Users` d ON p.idUser = d.id INNER JOIN `Education` t ON p.idEduc = t.id WHERE p.Result >= '0'", dbc);

                ValueAdapter.SelectCommand = ValueCommand;
                ValueAdapter.Fill(ValueTable);

                db.closeConnection(dbc);

                for (int i = 0; i < ValueTable.Rows.Count; i++) // перебираем данные  
                {
                    if (ValueTable.Rows[i][0].ToString().ToLower().Contains(TextBox.Text.ToLower()))
                    {
                        EducRes dataUser = new EducRes() // создаём экземпляр класса        
                        {
                            Name = ValueTable.Rows[i][1].ToString(), // указываем изображение из таблицы    
                            SurName = ValueTable.Rows[i][2].ToString(), // указываем логин         
                            FatherName = ValueTable.Rows[i][3].ToString(), // казываем пароль     
                            NameEduc = ValueTable.Rows[i][4].ToString(), // казываем пароль     
                            Result = ValueTable.Rows[i][5].ToString(), // казываем пароль     
                            Login = ValueTable.Rows[i][0].ToString() // казываем пароль     
                        };
                        listUsers.Items.Add(dataUser); // выводим строку в список 
                    }
                }
            }
        }
    }
}
