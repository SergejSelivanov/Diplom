using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LIS_Labtech
{
    /// <summary>
    /// Логика взаимодействия для PageTheory.xaml
    /// </summary>
    static class Path
    {
        public static string firstDocument1 { get; set; }
        public static string SecondDocument1 { get; set; }
        public static int flag { get; set; }
    }
    public partial class PageTheory : Page
    {
        string idEduc = "";
        string firstDocument = "";
        string SecondDocument = "";
        public PageTheory()
        {
            InitializeComponent();
            LoadEduc();
        }

        void LoadEduc()
        {
            DataBaseFunc DBF = new DataBaseFunc();
            DataTable CheckLogPass = DBF.getDataTableFromDB("NaznEduc", "idEduc", "`idUser`='" + Data.IdUser + "'");
            idEduc = CheckLogPass.Rows[CheckLogPass.Rows.Count-1][0].ToString();
            DataTable CheckLogPass1 = DBF.getDataTableFromDB("Education", "Name, firstDocument, secondDocument", "`id`='" + idEduc + "'");

            if (CheckLogPass1.Rows[CheckLogPass1.Rows.Count - 1][0].ToString() == "Методика определения пестицидов")
            {
                firstDocument = CheckLogPass1.Rows[CheckLogPass1.Rows.Count - 1][1].ToString();
                SecondDocument = CheckLogPass1.Rows[CheckLogPass1.Rows.Count - 1][2].ToString();
                Text1.Text = "Хромотография";
                Text2.Text = "Пестициды";
            }
            else if (CheckLogPass1.Rows[CheckLogPass1.Rows.Count - 1][0].ToString() == "Методика определения лактозы")
            {
                firstDocument = CheckLogPass1.Rows[CheckLogPass1.Rows.Count - 1][1].ToString();
                SecondDocument = CheckLogPass1.Rows[CheckLogPass1.Rows.Count - 1][2].ToString();
                Text1.Text = "Пестициды";
                Text2.Text = "Лактоза";
            }
            Path.firstDocument1 = firstDocument;
            Path.SecondDocument1 = SecondDocument;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Path.flag = 0;
            TheoryChooseWindow TheoryChooseWindow = new TheoryChooseWindow();
            TheoryChooseWindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Path.flag = 1;
            TheoryChooseWindow TheoryChooseWindow = new TheoryChooseWindow();
            TheoryChooseWindow.Show();
        }
    }
}
