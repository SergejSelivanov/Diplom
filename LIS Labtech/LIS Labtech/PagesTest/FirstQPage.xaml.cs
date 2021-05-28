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
    /// Логика взаимодействия для FirstQPage.xaml
    /// </summary>
    static class Tests
    {
        public static string first { get; set; }
        public static string Second { get; set; }
        public static string Third { get; set; }
        public static int Result { get; set; }
    }

    public partial class FirstQPage : Page
    {

        string idEduc = "";
        string NameTest = "";
        string Radio = "";
        string RadioR = "";
        public FirstQPage()
        {
            InitializeComponent();
            LoadEduc();
        }

        void LoadEduc()
        {
            DataBaseFunc DBF = new DataBaseFunc();
            DataTable CheckLogPass = DBF.getDataTableFromDB("NaznEduc", "idEduc", "`idUser`='" + Data.IdUser + "'");
            idEduc = CheckLogPass.Rows[CheckLogPass.Rows.Count - 1][0].ToString();
            DataTable CheckLogPass1 = DBF.getDataTableFromDB("Education", "Name, firstDocument, secondDocument", "`id`='" + idEduc + "'");
           NameTest = CheckLogPass1.Rows[CheckLogPass1.Rows.Count - 1][0].ToString();
            DataTable CheckLogPass2 = DBF.getDataTableFromDB("Tests", "idQuestion", "`Name`='" + NameTest + "'");
            Tests.first = CheckLogPass2.Rows[0][0].ToString();
            Tests.Second = CheckLogPass2.Rows[1][0].ToString();
            Tests.Third = CheckLogPass2.Rows[2][0].ToString();
            DataTable CheckLogPass3 = DBF.getDataTableFromDB("Questions", "Question, FirstVarient, SecondVarient, ThirdVarient, FourthVarient, RightVarient", "`id`='" + Tests.first + "'");
            FirstR.Content = CheckLogPass3.Rows[0][1].ToString();
            SecondR.Content = CheckLogPass3.Rows[0][2].ToString();
            ThirdR.Content = CheckLogPass3.Rows[0][3].ToString();
            FourthtR.Content = CheckLogPass3.Rows[0][4].ToString();
            Quest.Text = CheckLogPass3.Rows[0][0].ToString();
            Tests.Result = 0;
            RadioR = CheckLogPass3.Rows[0][5].ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Radio == RadioR)
                Tests.Result += 1;
            NavigationService.Navigate(new SecondQPage());
        }

        private void FirstR_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            Radio = pressed.Content.ToString();
        }

        private void SecondR_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            Radio = pressed.Content.ToString();
        }

        private void ThirdR_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            Radio = pressed.Content.ToString();
        }

        private void FourthtR_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            Radio = pressed.Content.ToString();
        }
    }
}
