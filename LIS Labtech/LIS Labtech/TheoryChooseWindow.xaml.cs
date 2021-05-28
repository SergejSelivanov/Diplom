using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для TheoryChooseWindow.xaml
    /// </summary>
    public partial class TheoryChooseWindow : Window
    {
        public TheoryChooseWindow()
        {
            InitializeComponent();
            LoadEduc();
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            EducationWindow EducationWindow = new EducationWindow();
            Hide();
        }

        void LoadEduc()
        {
            if (Path.flag == 0)
            {
                TextRange doc = new TextRange(Rich.Document.ContentStart, Rich.Document.ContentEnd);
                using (FileStream fs = new FileStream(Path.firstDocument1, FileMode.Open))
                {
                    doc.Load(fs, DataFormats.Rtf);
                }
            }
            else if (Path.flag == 1)
            {
                TextRange doc = new TextRange(Rich.Document.ContentStart, Rich.Document.ContentEnd);
                using (FileStream fs = new FileStream(Path.SecondDocument1, FileMode.Open))
                {
                    doc.Load(fs, DataFormats.Rtf);
                }
            }
        }
    }
}
