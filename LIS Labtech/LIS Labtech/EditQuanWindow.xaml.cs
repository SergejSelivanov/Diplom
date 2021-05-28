using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для EditQuanWindow.xaml
    /// </summary>
    public partial class EditQuanWindow : Window
    {
        int flag1 = 0;
        public EditQuanWindow(int flag)
        {
            InitializeComponent();
            flag1 = flag;
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            ManagerReportWindow AccOnOffWindow = new ManagerReportWindow();
            AccOnOffWindow.Show();
            Hide();
        }

        private void buttonOff_Click(object sender, RoutedEventArgs e)
        {
            var hasOnlyRChar = new Regex(@"^\d+$");
            if ((hasOnlyRChar.IsMatch(TextBox2.Text)))
            {
                DataBaseFunc DBF = new DataBaseFunc();
                if (flag1 == 0)
                {
                    int sum = 0;
                    sum = Convert.ToInt32(ingrCH.Quantity) + Convert.ToInt32(TextBox2.Text);
                    string tableName = "Reactives";
                    string setClause = "Quantity = '" + sum + "'";
                    string whereClause = "Name = '" + ingrCH.Name + "' AND Quantity = '" + ingrCH.Quantity + "' AND Volume = '" + ingrCH.Volume + "' AND Purity = '" + ingrCH.Purity + "' AND Class = '" + ingrCH.Class + "'";
                    DBF.updateTableFunc(tableName, setClause, whereClause);
                    ManagerReportWindow AccOnOffWindow = new ManagerReportWindow();
                    AccOnOffWindow.Show();
                    Hide();
                }
                else if (flag1 == 1)
                {
                    int sum = 0;
                    sum = Convert.ToInt32(materCH.Quantity) + Convert.ToInt32(TextBox2.Text);
                    string tableName = "Materials";
                    string setClause = "Quantity = '" + sum + "'";
                    string whereClause = "Name = '" + materCH.Name + "' AND Quantity = '" + materCH.Quantity + "' AND Volume = '" + materCH.Volume + "' AND Form = '" + materCH.Form + "' AND Type = '" + materCH.Type + "' AND Nazn = '" + materCH.Nazn + "'";
                    DBF.updateTableFunc(tableName, setClause, whereClause);
                    ManagerReportWindow AccOnOffWindow = new ManagerReportWindow();
                    AccOnOffWindow.Show();
                    Hide();
                }
            }
            else
            {
                MessageBox.Show("Введите число!");
            }

        }
    }
}
