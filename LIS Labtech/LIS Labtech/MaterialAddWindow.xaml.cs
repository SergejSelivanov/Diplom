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
    /// Логика взаимодействия для MaterialAddWindow.xaml
    /// </summary>
    public partial class MaterialAddWindow : Window
    {
        public MaterialAddWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ManagerReportWindow MaterialAddWindow = new ManagerReportWindow();
            MaterialAddWindow.Show();
            Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Textbox1.Text != "" && Textbox2.Text != "")
            {
                DataBaseFunc DBF = new DataBaseFunc();
                string tableName = "Materials";
                string columnsName = "Name, Quantity, Form, Volume, Type, Nazn";
                string values = "'" + Textbox1.Text + "', '" + Textbox2.Text + "', '" + Textbox3.Text + "', '" + Textbox4.Text + "', '" +
                  Textbox5.Text + "', '" + Textbox6.Text + "'";
                DBF.insertIntoTableFunc(tableName, columnsName, values);
                ManagerReportWindow MaterialAddWindow = new ManagerReportWindow();
                MaterialAddWindow.Show();
                Hide();
            }
            else
                MessageBox.Show("Обязательно введите название и колличество!");
        }
    }
}
