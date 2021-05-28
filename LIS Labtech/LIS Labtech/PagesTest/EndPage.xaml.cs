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
    /// Логика взаимодействия для EndPage.xaml
    /// </summary>
    public partial class EndPage : Page
    {
        public EndPage()
        {
            InitializeComponent(); //меняем доступ
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string idEduc = "";
            DataBaseFunc DBF = new DataBaseFunc();

            DataTable CheckLogPass = DBF.getDataTableFromDB("NaznEduc", "id", "`idUser`='" + Data.IdUser + "'");
            idEduc = CheckLogPass.Rows[CheckLogPass.Rows.Count - 1][0].ToString();

            string tableName = "Users";
            string setClause = "GetEduc = '" + 0 + "'";
            string whereClause = "id = '" + Data.IdUser + "'";
            DBF.updateTableFunc(tableName, setClause, whereClause);

            Console.WriteLine(idEduc);
            string tableName1 = "NaznEduc";
            string setClause1 = "Result = '" + Tests.Result + "'";
            string whereClause1 = "idUser = '" + Data.IdUser + "' AND id = '" + idEduc + "'";
            DBF.updateTableFunc(tableName1, setClause1, whereClause1);
            //меняем доступ
            End.Text = "Вы набрали " + Convert.ToString(Tests.Result) + " из 3 возможных.";
        }
    }
}
