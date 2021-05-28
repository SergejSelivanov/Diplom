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
    /// Логика взаимодействия для SucAnalWindow.xaml
    /// </summary>
    public partial class SucAnalWindow : Window
    {
        public SucAnalWindow()
        {
            InitializeComponent();
            OnLoad();
        }

        public void OnLoad()
        {
            TextBlock1.Text = "Первый этап: " + AnalSuc.FirstStepRes;
            TextBlock2.Text = "Второй этап: " + AnalSuc.SecondStepRes;
            TextBlock3.Text = "Третий этап: " + AnalSuc.ThirdStepRes;
            TextBlock4.Text = "Четвертый этап: " + AnalSuc.FourthStepRes;
            TextBlock6.Text = "Пестициды: " + AnalSuc.NormPest;
            TextBlock7.Text = "Лактоза: " + AnalSuc.NormLak;
            Nameblock.Text = AnalSuc.Name;
            Metblock.Text = AnalSuc.Metodic;
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            ManagerKontrolWindow ManagerKontrolWindow = new ManagerKontrolWindow();
            ManagerKontrolWindow.Show();
            Hide();
        }

        private void buttonOn_Click(object sender, RoutedEventArgs e)
        {
            DataBaseFunc DBF = new DataBaseFunc();

            string tableName = "Tasks";              //Закрываем задание на подтверждение и добавляем результаты
            string setClause = "Status = '" + "2" + "', " + "Resul = '" + "1" + "'";
            string whereClause = "Name = '" + AnalSuc.Name + "' AND Info = '" + AnalSuc.Info + "' AND ManagerOtv = '" + Data.LoginUser + "'";
            DBF.updateTableFunc(tableName, setClause, whereClause);
            ManagerKontrolWindow ManagerKontrolWindow = new ManagerKontrolWindow();
            ManagerKontrolWindow.Show();
            Hide();
        }

        private void buttonOff_Click(object sender, RoutedEventArgs e)
        {
            DataBaseFunc DBF = new DataBaseFunc();

            string tableName = "Tasks";              //Закрываем задание на подтверждение и добавляем результаты
            string setClause = "Status = '" + "2" + "', " + "Resul = '" + "2" + "'";
            string whereClause = "Name = '" + AnalSuc.Name + "' AND Info = '" + AnalSuc.Info + "' AND ManagerOtv = '" + Data.LoginUser + "'";
            DBF.updateTableFunc(tableName, setClause, whereClause);
            ManagerKontrolWindow ManagerKontrolWindow = new ManagerKontrolWindow();
            ManagerKontrolWindow.Show();
            Hide();
        }
    }
}
