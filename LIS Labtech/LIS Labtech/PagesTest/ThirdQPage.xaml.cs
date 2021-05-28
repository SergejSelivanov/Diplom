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
    /// Логика взаимодействия для ThirdQPage.xaml
    /// </summary>
    public partial class ThirdQPage : Page
    {
        string RadioR = "";
        string Radio = "";

        public ThirdQPage()
        {
            InitializeComponent();
            LoadEduc();
        }

        void LoadEduc()
        {
            DataBaseFunc DBF = new DataBaseFunc();
            DataTable CheckLogPass3 = DBF.getDataTableFromDB("Questions", "Question, FirstVarient, SecondVarient, ThirdVarient, FourthVarient, RightVarient", "`id`='" + Tests.Third + "'");
            FirstR.Content = CheckLogPass3.Rows[0][1].ToString();
            SecondR.Content = CheckLogPass3.Rows[0][2].ToString();
            ThirdR.Content = CheckLogPass3.Rows[0][3].ToString();
            FourthtR.Content = CheckLogPass3.Rows[0][4].ToString();
            Quest.Text = CheckLogPass3.Rows[0][0].ToString();
            RadioR = CheckLogPass3.Rows[0][5].ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Radio == RadioR)
                Tests.Result += 1;
            NavigationService.Navigate(new EndPage());
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
