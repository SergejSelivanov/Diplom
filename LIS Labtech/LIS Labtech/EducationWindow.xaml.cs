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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LIS_Labtech
{
    /// <summary>
    /// Логика взаимодействия для EducationWindow.xaml
    /// </summary>
    public partial class EducationWindow : Window
    {
        public EducationWindow()
        {
            InitializeComponent();
            MainView.Content = new PageTheory();
        }

        private void buttonTheory_Click(object sender, RoutedEventArgs e)
        {
            MainView.Content = new PageTheory();
        }

        private void buttonTest_Click(object sender, RoutedEventArgs e)
        {
            MainView.Content = new PageTest();
        }

        private void buttonExit_Click(object sender, RoutedEventArgs e)
        {
            LaborantWindow LaborantWindow = new LaborantWindow();
            LaborantWindow.Show();
            Hide();
        }
    }
}
