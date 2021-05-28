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
using System.Windows.Shapes;

namespace LIS_Labtech
{
    /// <summary>
    /// Логика взаимодействия для LaborantWindow.xaml
    /// </summary>
    
    
    public class Task3
    {
        public string Metodic { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
    }

    static class GoTest
    {
        public static string Metodic { get; set; }
        public static string Name { get; set; }
        public static string Info { get; set; }
        public static string FirstStep { get; set; }
        public static string SecondStep { get; set; }
        public static string ThirdStep { get; set; }
        public static string FourthStep { get; set; }
        public static string idUser { get; set; }
    }

    public partial class LaborantWindow : Window
    {
        public LaborantWindow()
        {
            InitializeComponent();
            CheckEduc();
            LoadUsers1();
        }

        void LoadUsers1()
        {
            DataBase db = new DataBase();
            MySqlConnection dbc = db.getConnection();

            if (dbc != null)
            {
                db.openConnection(dbc);

                DataTable ValueTable = new DataTable();
                MySqlDataAdapter ValueAdapter = new MySqlDataAdapter();

                MySqlCommand ValueCommand = new MySqlCommand("SELECT d.Name, t.Name, d.Info FROM `Tasks` d INNER JOIN `Users` p ON d.idUser = p.id INNER JOIN `Metodics` t ON d.idMetodic = t.id WHERE d.Status = '0' AND d.idUser = '" + @Data.IdUser + "'", dbc);
                ValueAdapter.SelectCommand = ValueCommand;
                ValueAdapter.Fill(ValueTable);

                db.closeConnection(dbc);

                for (int i = 0; i < ValueTable.Rows.Count; i++)
                {
                    Task3 dataUser = new Task3()
                    {
                        Name = ValueTable.Rows[i][0].ToString(),
                        Metodic = ValueTable.Rows[i][1].ToString(),
                        Info = ValueTable.Rows[i][2].ToString()
                    };
                    listUsers.Items.Add(dataUser);
                }
            }
        }

        private void CheckEduc()
        {
            DataBaseFunc DBF = new DataBaseFunc();
            DataTable CheckLogPass = DBF.getDataTableFromDB("Users", "GetEduc", "`id`='" + Data.IdUser + "'");
            if (CheckLogPass.Rows[0][0].ToString() == "0")
            {
                ButtonGoEd.Opacity = 0;
                ButtonGoEd.IsEnabled = false;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MainWindow = new MainWindow();
            MainWindow.Show();
            Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AcountWindow AcountWindow = new AcountWindow();
            AcountWindow.Show();
            Hide();
        }

        private void ButtonGoEd_Click(object sender, RoutedEventArgs e)
        {
            EducationWindow EducationWindow = new EducationWindow();
            EducationWindow.Show();
            Hide();
        }

        private void listUsers_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            DataBaseFunc DBF = new DataBaseFunc();          //получение необходимых данных
            Task3 firstItem = e.AddedItems[0] as Task3;
            if (firstItem != null)
            {
                GoTest.Metodic = firstItem.Metodic;
                GoTest.Name = firstItem.Name;
                GoTest.Info = firstItem.Info;
            }

            DataTable CheckLogPass = DBF.getDataTableFromDB("Metodics", "FirstStep, SecondStep, ThirdStep, FourthStep", "`Name`='" + GoTest.Metodic + "'");
            GoTest.FirstStep = CheckLogPass.Rows[0][0].ToString();
            GoTest.SecondStep = CheckLogPass.Rows[0][1].ToString();
            GoTest.ThirdStep = CheckLogPass.Rows[0][2].ToString();
            GoTest.FourthStep = CheckLogPass.Rows[0][3].ToString();

            GoTest.idUser = Data.IdUser;

            MakeAnalWindow MakeAnalWindow = new MakeAnalWindow();
            MakeAnalWindow.Show();
            Hide();
        }
    }
}
