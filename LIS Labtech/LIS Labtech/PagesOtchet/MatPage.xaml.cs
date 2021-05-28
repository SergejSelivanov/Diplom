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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LIS_Labtech
{
    /// <summary>
    /// Логика взаимодействия для MatPage.xaml
    /// </summary>
    public partial class MatPage : Page
    {
        public MatPage()
        {
            InitializeComponent();
            OnLoad();
            OnLoad1();
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
    }
}
