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
    /// Логика взаимодействия для EdNazn1Window.xaml
    /// </summary>

    public partial class EdNazn1Window : Window
    {
        public EdNazn1Window()
        {
            InitializeComponent();
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            EdNazWindow EdNazWindow = new EdNazWindow();
            EdNazWindow.Show();
            Hide();
        }

        private void buttonOn_Click(object sender, RoutedEventArgs e)
        {
            if (ComboBox.Text != "")
            {
                string idEduc = "";
                string idUser = "";

                DataBaseFunc DBF = new DataBaseFunc();

                string tableName = "Users";
                string setClause = "GetEduc = '" + "3" + "'";
                string whereClause = "Login = '" + EdNazn.LoginUser + "'";
                DBF.updateTableFunc(tableName, setClause, whereClause);

                DataTable CheckLogPass1 = DBF.getDataTableFromDB("Education", "id", "`Name`='" + ComboBox.Text + "'");
                if (CheckLogPass1.Rows.Count > 0)
                {
                    idEduc = CheckLogPass1.Rows[0][0].ToString();
                }
                DataTable CheckLogPass2 = DBF.getDataTableFromDB("Users", "id", "`Login`='" + EdNazn.LoginUser + "'");
                if (CheckLogPass2.Rows.Count > 0)
                {
                    idUser = CheckLogPass2.Rows[0][0].ToString();
                }

                int idEduc1 = int.Parse(idEduc);
                int idUser1 = int.Parse(idUser);
                string tableName1 = "NaznEduc";
                string columnsName = "idUser, idEduc";
                string values = "'" + idUser1 + "', '" + idEduc1 + "'";
                DBF.insertIntoTableFunc(tableName1, columnsName, values);
                EdNazWindow EdNazWindow = new EdNazWindow();
                EdNazWindow.Show();
                Hide();
            }
        }
    }
}
