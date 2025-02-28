using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Task.Task1
{
//Task 1: 
//User class - UserName,Password; 
//CheckPassword - sifrenin uzunlugu min8, icnde uppercase ve digit olmalidir
//Constructorda username ve password istenilir ve uygun deyilse set edilmeyecek.
//SetPassword metodu - eger sifre uygundursa password field-ne value set edir, deyilse xeta mesaji verir
    public class User
    {
        public string UserName { get; set; }
        private string _password;

        //public User(string userName,string password)
        //{
        //    userName = UserName;
        //    if (_password.Length >= 8 && password.Any(char.IsUpper) && password.Any(char.IsDigit))
        //    {
        //        password = _password;
        //    }
        //    else
        //    {
        //        throw new Exception("Sifre duzgun deyil");
        //    }
        //}
        public string GetPassword()
        {
            return _password;
        }
        public void SetPassword(string password) 
        {
            if (password.Length >= 8 && password.Any(char.IsUpper) && password.Any(char.IsDigit) && password.Any(char.IsLower) && !password.Any(char.IsLetterOrDigit))
            {
                _password = password;
            }
            else
            {
                throw new Exception("Sifre duzgun deyil");
            }
        }
    }
}
 