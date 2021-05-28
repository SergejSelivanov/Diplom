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
    /// Логика взаимодействия для AddApplWindow.xaml
    /// </summary>
    static class AddAppl
    {
        public static string Name { get; set; }
        public static string LoginUser { get; set; }
        public static string SurName { get; set; }
        public static string FatherName { get; set; }
    }

    public partial class AddApplWindow : Window
    {
        public AddApplWindow()
        {
            InitializeComponent();
            LoadUsers();
        }

        void LoadUsers()
        {
            DataBaseFunc DBF = new DataBaseFunc();
            DataTable CheckLogPass = DBF.getDataTableFromDB("Users", "Name, SurName, FatherName, Login", "`Status`='" + "1" + "' AND `Position` ='" + "Менеджер по контролю качества" + "'");
            for (int i = 0; i < CheckLogPass.Rows.Count; i++)
            {
                DataBaseFunc.user dataUser = new DataBaseFunc.user()      
                {
                    Name = CheckLogPass.Rows[i][0].ToString(),  
                    SurName = CheckLogPass.Rows[i][1].ToString(),     
                    FatherName = CheckLogPass.Rows[i][2].ToString(),
                    Login = CheckLogPass.Rows[i][3].ToString()   
                };
                listUsers.Items.Add(dataUser);
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
            DataBaseFunc.user firstItem = e.AddedItems[0] as DataBaseFunc.user;
            if (firstItem != null)
            {
                AddAppl.LoginUser = firstItem.Login;
                AddAppl.Name = firstItem.Name;
                AddAppl.SurName = firstItem.SurName;
                AddAppl.FatherName = firstItem.FatherName;
                AddApplForMWindow AddApplForMWindow = new AddApplForMWindow();
                AddApplForMWindow.Show();
                Hide();
            }
        }
    }
}
