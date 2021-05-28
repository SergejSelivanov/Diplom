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
    /// Логика взаимодействия для ManagerKontrolWindow.xaml
    /// </summary>
    public class Task1
    {
        public string Metodic { get; set; }
        public string Name { get; set; }
        public string Laborant { get; set; }
        public string Laborant1 { get; set; }
        public string Info { get; set; }
    }
    
    public class Task2
    {
        public string Metodic { get; set; }
        public string Name { get; set; }
        public string Laborant { get; set; }
        public string Laborant1 { get; set; }
        public string Info { get; set; }
    }
    
    public static class AnalSuc
    {
        public static string Name { get; set; }
        public static string Manager { get; set; }
        public static string Info { get; set; }
        public static string FirstStepRes { get; set; }
        public static string SecondStepRes { get; set; }
        public static string ThirdStepRes { get; set; }
        public static string FourthStepRes { get; set; }
        public static string NormPest { get; set; }
        public static string NormLak { get; set; }
        public static string Metodic { get; set; }
    }

    public partial class ManagerKontrolWindow : Window
    {
        public ManagerKontrolWindow()
        {
            InitializeComponent();
            LoadUsers1();
            LoadUsers2();
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

                MySqlCommand ValueCommand = new MySqlCommand("SELECT d.Name, t.Name, p.Name, p.SurName, d.Info FROM `Tasks` d INNER JOIN `Users` p ON d.idUser = p.id INNER JOIN `Metodics` t ON d.idMetodic = t.id WHERE d.Status = '0' AND d.ManagerOtv = '" + @Data.LoginUser + "'", dbc);
                ValueAdapter.SelectCommand = ValueCommand;
                ValueAdapter.Fill(ValueTable);

                db.closeConnection(dbc);

                for (int i = 0; i < ValueTable.Rows.Count; i++)
                {
                    Task1 dataUser = new Task1()    
                    {
                        Name = ValueTable.Rows[i][0].ToString(),  
                        Metodic = ValueTable.Rows[i][1].ToString(),       
                        Laborant = ValueTable.Rows[i][2].ToString(),   
                        Laborant1 = ValueTable.Rows[i][3].ToString(),   
                        Info = ValueTable.Rows[i][4].ToString()   
                    };
                    listUsers.Items.Add(dataUser);
                }
            }
        }

        void LoadUsers2()
        {
            DataBase db = new DataBase();
            MySqlConnection dbc = db.getConnection();

            if (dbc != null)
            {
                db.openConnection(dbc);

                DataTable ValueTable = new DataTable();
                MySqlDataAdapter ValueAdapter = new MySqlDataAdapter();

                MySqlCommand ValueCommand = new MySqlCommand("SELECT d.Name, t.Name, p.Name, p.SurName, d.Info FROM `Tasks` d INNER JOIN `Users` p ON d.idUser = p.id INNER JOIN `Metodics` t ON d.idMetodic = t.id WHERE d.Status = '1' AND d.ManagerOtv = '" + @Data.LoginUser + "'", dbc);
                ValueAdapter.SelectCommand = ValueCommand;
                ValueAdapter.Fill(ValueTable);

                db.closeConnection(dbc);

                for (int i = 0; i < ValueTable.Rows.Count; i++)
                {
                    Task2 dataUser = new Task2()
                    {
                        Name = ValueTable.Rows[i][0].ToString(),
                        Metodic = ValueTable.Rows[i][1].ToString(),
                        Laborant = ValueTable.Rows[i][2].ToString(),
                        Laborant1 = ValueTable.Rows[i][3].ToString(),
                        Info = ValueTable.Rows[i][4].ToString()
                    };
                    listUsers1.Items.Add(dataUser);
                }
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

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AddTaskWindow AddTaskWindow = new AddTaskWindow();
            AddTaskWindow.Show();
            Hide();
        }

        private void listUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void listUsers1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataBaseFunc DBF = new DataBaseFunc();          //получение необходимых данных
            Task2 firstItem = e.AddedItems[0] as Task2;
            if (firstItem != null)
            {
                AnalSuc.Name = firstItem.Name;
                AnalSuc.Info = firstItem.Info;
                AnalSuc.Metodic = firstItem.Metodic;

                DataTable CheckLogPass = DBF.getDataTableFromDB("Tasks", "FirstStepRes, SecondStepRes, ThirdStepRes, FourthStepRes", "`ManagerOtv`='" + Data.LoginUser + "' AND `Name`='"+ AnalSuc.Name + "' AND `Info`='" + AnalSuc.Info + "'");

                AnalSuc.FirstStepRes = CheckLogPass.Rows[0][0].ToString();
                AnalSuc.SecondStepRes = CheckLogPass.Rows[0][1].ToString();
                AnalSuc.ThirdStepRes = CheckLogPass.Rows[0][2].ToString();
                AnalSuc.FourthStepRes = CheckLogPass.Rows[0][3].ToString();


                DataBase db = new DataBase();
                MySqlConnection dbc = db.getConnection();

                if (dbc != null)
                {
                    db.openConnection(dbc);

                    DataTable ValueTable = new DataTable();
                    MySqlDataAdapter ValueAdapter = new MySqlDataAdapter();

                    MySqlCommand ValueCommand = new MySqlCommand("SELECT d.Name FROM `Tasks` p INNER JOIN `Metodics` d ON p.idMetodic = d.id WHERE p.Name = '" + @AnalSuc.Name + "' AND p.ManagerOtv = '" + @Data.LoginUser + "' AND p.Info = '" + @AnalSuc.Info + "'", dbc);
                    ValueAdapter.SelectCommand = ValueCommand;
                    ValueAdapter.Fill(ValueTable);

                    db.closeConnection(dbc);

                    string NameMetodic1 = ValueTable.Rows[0][0].ToString();

                    db.openConnection(dbc);

                    DataTable ValueTable1 = new DataTable();
                    MySqlDataAdapter ValueAdapter1 = new MySqlDataAdapter();

                    MySqlCommand ValueCommand1 = new MySqlCommand("SELECT d.NormLak, d.NormPest FROM `Metodics` p INNER JOIN `Normatives` d ON p.idNormativ = d.id WHERE p.Name = '" + @NameMetodic1 + "'", dbc);
                    ValueAdapter1.SelectCommand = ValueCommand1;
                    ValueAdapter1.Fill(ValueTable1);

                    db.closeConnection(dbc);

                    AnalSuc.NormLak = ValueTable1.Rows[0][0].ToString();
                    AnalSuc.NormPest = ValueTable1.Rows[0][1].ToString();

                }




                SucAnalWindow SucAnalWindow = new SucAnalWindow();
                SucAnalWindow.Show();
                Hide();
            }
        }
    }
}
