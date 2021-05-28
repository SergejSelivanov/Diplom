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
    /// Логика взаимодействия для MakeAnalWindow.xaml
    /// </summary>
    public partial class MakeAnalWindow : Window
    {
        public MakeAnalWindow()
        {
            InitializeComponent();
            OnLoad();
        }

        public void OnLoad()
        {
            TextBlock1.Text = GoTest.FirstStep;
            TextBlock2.Text = GoTest.SecondStep;
            TextBlock3.Text = GoTest.ThirdStep;
            TextBlock4.Text = GoTest.FourthStep;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LaborantWindow LaborantWindow = new LaborantWindow();
            LaborantWindow.Show();
            Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Textbox1.Text != "" && Textbox2.Text != "" && Textbox3.Text != "" && Textbox4.Text != "")
            {
                DataBaseFunc DBF = new DataBaseFunc();

                string tableName = "Tasks";              //Закрываем задание на подтверждение и добавляем результаты
                string setClause = "Status = '" + "1" + "', " + "FirstStepRes = '" + Textbox1.Text + "', " + "SecondStepRes = '" + Textbox2.Text + "', " + "ThirdStepRes = '" + Textbox3.Text + "', " + "FourthStepRes = '" + Textbox4.Text + "'";
                string whereClause = "Name = '" + GoTest.Name + "' AND Info = '" + GoTest.Info + "' AND idUser = '" + GoTest.idUser + "'";
                DBF.updateTableFunc(tableName, setClause, whereClause);

                LaborantWindow LaborantWindow = new LaborantWindow();
                LaborantWindow.Show();
                Hide();
            }
            else
                MessageBox.Show("Обязательно заполните поля!");
        }
    }
}
