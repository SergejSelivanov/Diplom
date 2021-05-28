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
    /// Логика взаимодействия для AddTaskChooseLWindow.xaml
    /// </summary>
    public partial class AddTaskChooseLWindow : Window
    {
        public AddTaskChooseLWindow()
        {
            InitializeComponent();
            LoadUsers();
        }

        void LoadUsers()
        {
            DataBaseFunc DBF = new DataBaseFunc();
            DataTable CheckLogPass = DBF.getDataTableFromDB("Users", "Name, SurName, FatherName, Telefon, Position, Login", "`Status`='" + "1" + "' AND `Position` = '" + "Лаборант" + "'");
            for (int i = 0; i < CheckLogPass.Rows.Count; i++) // перебираем данные  
            {
                DataBaseFunc.user dataUser = new DataBaseFunc.user() // создаём экземпляр класса        
                {
                    Name = CheckLogPass.Rows[i][0].ToString(), // указываем изображение из таблицы    
                    SurName = CheckLogPass.Rows[i][1].ToString(), // указываем логин         
                    FatherName = CheckLogPass.Rows[i][2].ToString(), // казываем пароль     
                    Telefon = CheckLogPass.Rows[i][3].ToString(),  
                    Position = CheckLogPass.Rows[i][4].ToString(),  
                    Login = CheckLogPass.Rows[i][5].ToString() 
                };
                listUsers.Items.Add(dataUser);
            }
        }

        private void listUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string idUser = "";
            string idMetodic = "";
            string LoginUser = "";


            DataBaseFunc DBF = new DataBaseFunc();

            DataBaseFunc.user firstItem = e.AddedItems[0] as DataBaseFunc.user;
            if (firstItem != null)
            {
                LoginUser = firstItem.Login;
            }

            DataTable CheckLogPass = DBF.getDataTableFromDB("Users", "id", "`Login`='" + LoginUser + "'");  //получили id
            idUser = CheckLogPass.Rows[0][0].ToString();

            DataTable CheckLogPass1 = DBF.getDataTableFromDB("Metodics", "id", "`Name`='" + Metodic.Name + "'");  //получили id
            idMetodic = CheckLogPass1.Rows[0][0].ToString();

            string tableName = "Applications";              //Закрыли заявку
            string setClause = "Status = '" + "1" + "'";
            string whereClause = "Name = '" + Metodic.NameofAppl + "' AND Metodic = '" + Metodic.Name + "' AND Info = '" + Metodic.Info + "'";
            DBF.updateTableFunc(tableName, setClause, whereClause);

            string tableName1 = "Tasks";            //Добавляем задание
            string columnsName = "idUser, idMetodic, Name, Info, ManagerOtv";
            string values = "'" + idUser + "', '" + idMetodic + "', '" + Metodic.NameofAppl + "', '" + Metodic.Info + "', '" + Data.LoginUser + "'";
            DBF.insertIntoTableFunc(tableName1, columnsName, values);

            AddTaskWindow AddTaskChooseLWindow = new AddTaskWindow();
            AddTaskChooseLWindow.Show();
            Hide();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddTaskWindow AddTaskChooseLWindow = new AddTaskWindow();
            AddTaskChooseLWindow.Show();
            Hide();
        }
    }
}
