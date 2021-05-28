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
using System.Windows.Shapes;

namespace LIS_Labtech
{
    /// <summary>
    /// Логика взаимодействия для ManagerReportWindow.xaml
    /// </summary>

    static class ingrCH
    {
        public static string Name { get; set; }
        public static string Quantity { get; set; }
        public static string Volume { get; set; }
        public static string Purity { get; set; }
        public static string Class { get; set; }
    }

    static class materCH
    {
        public static string Name { get; set; }
        public static string Quantity { get; set; }
        public static string Volume { get; set; }
        public static string Form { get; set; }
        public static string Type { get; set; }
        public static string Nazn { get; set; }
    }

    public class ingr
    {
        public string Name { get; set; }
        public string Quantity { get; set; }
        public string Volume { get; set; }
        public string Purity { get; set; }
        public string Class { get; set; }
    }
    public class mater
    {
        public string Name { get; set; }
        public string Quantity { get; set; }
        public string Volume { get; set; }
        public string Form { get; set; }
        public string Type { get; set; }
        public string Nazn { get; set; }
    }

    public partial class ManagerReportWindow : Window
    {
        public ManagerReportWindow()
        {
            InitializeComponent();
            OnLoad();
            OnLoad1();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MainWindow = new MainWindow();
            MainWindow.Show();
            Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AcountWindow AcountWindow = new AcountWindow();
            AcountWindow.Show();
            Hide();
        }

        void OnLoad()
        {
            DataBaseFunc DBF = new DataBaseFunc();
            DataTable CheckLogPass = DBF.getDataTableFromDBwithoutWhere("Reactives", "Name, Quantity, Volume, Purity, Class");
            for (int i = 0; i < CheckLogPass.Rows.Count; i++) // перебираем данные  
            {
                ingr dataUser = new ingr() // создаём экземпляр класса        
                {
                    Name = CheckLogPass.Rows[i][0].ToString(), // указываем изображение из таблицы    
                    Quantity = CheckLogPass.Rows[i][1].ToString(), // указываем логин         
                    Volume = CheckLogPass.Rows[i][2].ToString(), // казываем пароль     
                    Purity = CheckLogPass.Rows[i][3].ToString(), // казываем пароль     
                    Class = CheckLogPass.Rows[i][4].ToString() // казываем пароль     
                };
                listUsers.Items.Add(dataUser); // выводим строку в список 
            }
        }

        void OnLoad1()
        {
            DataBaseFunc DBF = new DataBaseFunc();
            DataTable CheckLogPass1 = DBF.getDataTableFromDBwithoutWhere("Materials", "Name, Quantity, Volume, Form, Type, Nazn");
            for (int i = 0; i < CheckLogPass1.Rows.Count; i++) // перебираем данные  
            {
                mater dataUser = new mater() // создаём экземпляр класса        
                {
                    Name = CheckLogPass1.Rows[i][0].ToString(), // указываем изображение из таблицы    
                    Quantity = CheckLogPass1.Rows[i][1].ToString(), // указываем логин         
                    Volume = CheckLogPass1.Rows[i][2].ToString(), // казываем пароль     
                    Form = CheckLogPass1.Rows[i][3].ToString(), // казываем пароль     
                    Type = CheckLogPass1.Rows[i][4].ToString(), // казываем пароль     
                    Nazn = CheckLogPass1.Rows[i][5].ToString() // казываем пароль     
                };
                listUsers1.Items.Add(dataUser); // выводим строку в список 
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MaterialAddWindow MaterialAddWindow = new MaterialAddWindow();
            MaterialAddWindow.Show();
            Hide();
        }

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            listUsers.Items.Clear();
            DataBaseFunc DBF = new DataBaseFunc();
            DataTable CheckLogPass = DBF.getDataTableFromDBwithoutWhere("Reactives", "Name, Quantity, Volume, Purity, Class");
            for (int i = 0; i < CheckLogPass.Rows.Count; i++) // перебираем данные  
            {
                if (CheckLogPass.Rows[i][0].ToString().ToLower().Contains(TextBox1.Text.ToLower()))
                {
                    ingr dataUser = new ingr() // создаём экземпляр класса        
                    {
                        Name = CheckLogPass.Rows[i][0].ToString(), // указываем изображение из таблицы    
                        Quantity = CheckLogPass.Rows[i][1].ToString(), // указываем логин         
                        Volume = CheckLogPass.Rows[i][2].ToString(), // казываем пароль     
                        Purity = CheckLogPass.Rows[i][3].ToString(), // казываем пароль     
                        Class = CheckLogPass.Rows[i][4].ToString() // казываем пароль     
                    };
                    listUsers.Items.Add(dataUser); // выводим строку в список 
                }
            }
        }

        private void TextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            listUsers1.Items.Clear();
            DataBaseFunc DBF = new DataBaseFunc();
            DataTable CheckLogPass1 = DBF.getDataTableFromDBwithoutWhere("Materials", "Name, Quantity, Volume, Form, Type, Nazn");
            for (int i = 0; i < CheckLogPass1.Rows.Count; i++) // перебираем данные  
            {
                if (CheckLogPass1.Rows[i][0].ToString().ToLower().Contains(TextBox2.Text.ToLower()))
                {
                    mater dataUser = new mater() // создаём экземпляр класса        
                    {
                        Name = CheckLogPass1.Rows[i][0].ToString(), // указываем изображение из таблицы    
                        Quantity = CheckLogPass1.Rows[i][1].ToString(), // указываем логин         
                        Volume = CheckLogPass1.Rows[i][2].ToString(), // казываем пароль     
                        Form = CheckLogPass1.Rows[i][3].ToString(), // казываем пароль     
                        Type = CheckLogPass1.Rows[i][4].ToString(), // казываем пароль     
                        Nazn = CheckLogPass1.Rows[i][5].ToString() // казываем пароль     
                    };
                    listUsers1.Items.Add(dataUser); // выводим строку в список 
                }
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            IngridientAddWindow MaterialAddWindow = new IngridientAddWindow();
            MaterialAddWindow.Show();
            Hide();
        }

        private void listUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ingr firstItem = e.AddedItems[0] as ingr;    // cast..
            if (firstItem != null)                                          // if not null..
            {
                ingrCH.Name = firstItem.Name;
                ingrCH.Quantity = firstItem.Quantity;
                ingrCH.Volume = firstItem.Volume;
                ingrCH.Purity = firstItem.Purity;
                ingrCH.Class = firstItem.Class;
                EditQuanWindow AccOnOffWindow = new EditQuanWindow(0);
                AccOnOffWindow.Show();
                Hide();
            }
        }

        private void listUsers1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            mater firstItem = e.AddedItems[0] as mater;    // cast..
            if (firstItem != null)                                          // if not null..
            {
                materCH.Name = firstItem.Name;
                materCH.Quantity = firstItem.Quantity;
                materCH.Volume = firstItem.Volume;
                materCH.Form = firstItem.Form;
                materCH.Type = firstItem.Type;
                materCH.Nazn = firstItem.Nazn;
                EditQuanWindow AccOnOffWindow = new EditQuanWindow(1);
                AccOnOffWindow.Show();
                Hide();
            }
        }
    }
}
