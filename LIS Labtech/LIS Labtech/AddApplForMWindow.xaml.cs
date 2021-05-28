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
    /// Логика взаимодействия для AddApplForMWindow.xaml
    /// </summary>
    public partial class AddApplForMWindow : Window
    {
        public AddApplForMWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Textbox1.Text != "" && Textbox2.Text != "" && ComboBox.Text != "")
            {
                DataBaseFunc DBF = new DataBaseFunc();

                DataTable CheckLogPass = DBF.getDataTableFromDB("Users", "id", "`Name`='" + AddAppl.Name + "' AND `SurName` = '" + AddAppl.SurName + "' AND `FatherName` = '" + AddAppl.FatherName + "' AND `Login` = '" + AddAppl.LoginUser + "'");

                string id = CheckLogPass.Rows[0][0].ToString();


                string tableName = "Applications";
                string columnsName = "Name, Metodic, idUser, Info";
                string values = "'" + Textbox1.Text + "', '" + ComboBox.Text + "', '" + id + "', '" + Textbox2.Text + "'";
                DBF.insertIntoTableFunc(tableName, columnsName, values);
                AddApplWindow AddApplWindow = new AddApplWindow();
                AddApplWindow.Show();
                Hide();
            }
            else
                MessageBox.Show("Обязательно заполните поля!");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddApplWindow AddApplWindow = new AddApplWindow();
            AddApplWindow.Show();
            Hide();
        }
    }
}
