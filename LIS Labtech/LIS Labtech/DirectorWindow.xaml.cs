using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    /// Логика взаимодействия для DirectorWindow.xaml
    /// </summary>

    public static class DirSee
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
        public static string Result { get; set; }
    }

    public class Task4
    {
        public string Metodic { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
    }

    public partial class DirectorWindow : Window
    {
        public DirectorWindow()
        {
            InitializeComponent();
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

                MySqlCommand ValueCommand = new MySqlCommand("SELECT d.Name, t.Name, d.Info FROM `Tasks` d INNER JOIN `Users` p ON d.idUser = p.id INNER JOIN `Metodics` t ON d.idMetodic = t.id WHERE d.Status = '2'", dbc);
                ValueAdapter.SelectCommand = ValueCommand;
                ValueAdapter.Fill(ValueTable);

                db.closeConnection(dbc);

                for (int i = 0; i < ValueTable.Rows.Count; i++)
                {
                    Task4 dataUser = new Task4()
                    {
                        Name = ValueTable.Rows[i][0].ToString(),
                        Metodic = ValueTable.Rows[i][1].ToString(),
                        Info = ValueTable.Rows[i][2].ToString()
                    };
                    listUsers.Items.Add(dataUser);
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
            SucsessAccWindow SucsessAccWindow = new SucsessAccWindow();
            SucsessAccWindow.Show();
            Hide();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            EdNazWindow EdNazWindow = new EdNazWindow();
            EdNazWindow.Show();
            Hide();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            OtchetWindow OtchetWindow = new OtchetWindow();
            OtchetWindow.Show();
            Hide();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            AddApplWindow AddApplWindow = new AddApplWindow();
            AddApplWindow.Show();
            Hide();
        }

        private void listUsers_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            DataBaseFunc DBF = new DataBaseFunc();          //получение необходимых данных
            Task4 firstItem = e.AddedItems[0] as Task4;
            if (firstItem != null)
            {
                DirSee.Name = firstItem.Name;
                DirSee.Info = firstItem.Info;
                DirSee.Metodic = firstItem.Metodic;

                DataTable CheckLogPass = DBF.getDataTableFromDB("Tasks", "FirstStepRes, SecondStepRes, ThirdStepRes, FourthStepRes, Resul", "`Name`='" + DirSee.Name + "' AND `Info`='" + DirSee.Info + "'");

                DirSee.FirstStepRes = CheckLogPass.Rows[0][0].ToString();
                DirSee.SecondStepRes = CheckLogPass.Rows[0][1].ToString();
                DirSee.ThirdStepRes = CheckLogPass.Rows[0][2].ToString();
                DirSee.FourthStepRes = CheckLogPass.Rows[0][3].ToString();
                DirSee.Result = CheckLogPass.Rows[0][4].ToString();


                DataBase db = new DataBase();
                MySqlConnection dbc = db.getConnection();

                if (dbc != null)
                {
                    db.openConnection(dbc);

                    DataTable ValueTable = new DataTable();
                    MySqlDataAdapter ValueAdapter = new MySqlDataAdapter();

                    MySqlCommand ValueCommand = new MySqlCommand("SELECT d.Name FROM `Tasks` p INNER JOIN `Metodics` d ON p.idMetodic = d.id WHERE p.Name = '" + @DirSee.Name + "' AND p.Info = '" + @DirSee.Info + "'", dbc);
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

                    DirSee.NormLak = ValueTable1.Rows[0][0].ToString();
                    DirSee.NormPest = ValueTable1.Rows[0][1].ToString();



                }
            }
            AnalSeeWindow MainWindow = new AnalSeeWindow();
            MainWindow.Show();
            Hide();
        }
    }
}
