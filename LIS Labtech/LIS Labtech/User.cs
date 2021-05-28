using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIS_Labtech
{
    class User
    {
        public int id { get; set; }

        private string Login, Password, Name, Status, Email, SurName, FatherName, Position, Telefon;

        public string login
        {
            get { return Login; }
            set { Login = value; }

        }        
        
        public string password
        {
            get { return Password; }
            set { Password = value; }

        }       
        
        public string name
        {
            get { return Name; }
            set { Name = value; }

        }       
       
        public string status
        {
            get { return Status; }
            set { Status = value; }

        }       
       
        public string email
        {
            get { return Email; }
            set { Email = value; }

        }        
        
        public string surName
        {
            get { return SurName; }
            set { SurName = value; }

        }     
        
        public string fatherName
        {
            get { return FatherName; }
            set { FatherName = value; }

        }       
        
        public string position
        {
            get { return Position; }
            set { Position = value; }

        }        
        
        public string telefon
        {
            get { return Telefon; }
            set { Telefon = value; }

        }
        public User() { }

        public User(string Login, string Password, string Name, string Status, string Email, string SurName, string FatherName, string Position, string Telefon)
        {
            this.Login = Login;
            this.Password = Password;
            this.Name = Name;
            this.Status = Status;
            this.Email = Email;
            this.SurName = SurName;
            this.FatherName = FatherName;
            this.Position = Position;
            this.Telefon = Telefon;
        }
    }
}
