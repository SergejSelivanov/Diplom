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
    /// Логика взаимодействия для AddTaskWindow.xaml
    /// </summary>

    public class ApplAdd
    {
        public string Name { get; set; }
        public string Metodic { get; set; }
        public string Info { get; set; }
    }

    public static class Metodic
    {
        public static string Name { get; set; }
        public static string NameofAppl { get; set; }
        public static string Info { get; set; }
    }

    public partial class AddTaskWindow : Window
    {
        public AddTaskWindow()
        {
            InitializeComponent();
            LoadUsers();
        }

        void LoadUsers()
        {
            DataBaseFunc DBF = new DataBaseFunc();
            DataTable CheckLogPass = DBF.getDataTableFromDB("Applications", "Name, Metodic, Info", "`idUser`='" + Data.IdUser + "' AND `Status` = '"+ "0" +"'");
            for (int i = 0; i < CheckLogPass.Rows.Count; i++)
            {
                ApplAdd dataUser = new ApplAdd()
                {
                    Name = CheckLogPass.Rows[i][0].ToString(),
                    Metodic = CheckLogPass.Rows[i][1].ToString(),
                    Info = CheckLogPass.Rows[i][2].ToString()
                };
                listUsers.Items.Add(dataUser);
            }
        }

        private void listUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataBaseFunc DBF = new DataBaseFunc();
            ApplAdd firstItem = e.AddedItems[0] as ApplAdd;    // cast..
            if (firstItem != null)                                          // if not null..
            {
                Metodic.Name = firstItem.Metodic;
                Metodic.NameofAppl = firstItem.Name;
                Metodic.Info = firstItem.Info;
                AddTaskChooseLWindow AddTaskChooseLWindow = new AddTaskChooseLWindow();
                AddTaskChooseLWindow.Show();
                Hide();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ManagerKontrolWindow ManagerKontrolWindow = new ManagerKontrolWindow();
            ManagerKontrolWindow.Show();
            Hide();
        }
    }
}
