using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для OtchetWindow.xaml
    /// </summary>
    public partial class OtchetWindow : Window
    {
        public OtchetWindow()
        {
            InitializeComponent();
            MainView.Content = new EducGetPage();
        }

        private void buttonEduc_Click(object sender, RoutedEventArgs e)
        {
            MainView.Content = new EducGetPage();
        }

        private void buttonMat_Click(object sender, RoutedEventArgs e)
        {
            MainView.Content = new MatPage();
        }

        private void buttonExit_Click(object sender, RoutedEventArgs e)
        {
            DirectorWindow DirectorWindow = new DirectorWindow();
            DirectorWindow.Show();
            Hide();
        }
    }
}
