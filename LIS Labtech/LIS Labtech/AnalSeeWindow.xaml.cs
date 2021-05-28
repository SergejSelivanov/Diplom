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
    /// Логика взаимодействия для AnalSeeWindow.xaml
    /// </summary>
    public partial class AnalSeeWindow : Window
    {
        public AnalSeeWindow()
        {
            InitializeComponent();
            OnLoad();
        }

        public void OnLoad()
        {
            TextBlock1.Text = "Первый этап: " + DirSee.FirstStepRes;
            TextBlock2.Text = "Второй этап: " + DirSee.SecondStepRes;
            TextBlock3.Text = "Третий этап: " + DirSee.ThirdStepRes;
            TextBlock4.Text = "Четвертый этап: " + DirSee.FourthStepRes;
            TextBlock6.Text = "Пестициды: " + DirSee.NormPest;
            TextBlock7.Text = "Лактоза: " + DirSee.NormLak;
            Nameblock.Text = DirSee.Name;
            Metblock.Text = DirSee.Metodic;
            if (DirSee.Result == "1")
            {
                Resblock.Text = "Пройден";
            }
            else
            {
                Resblock.Text = "Не пройден";
            }
            
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            DirectorWindow SucAnalWindow = new DirectorWindow();
            SucAnalWindow.Show();
            Hide();
        }
    }
}
