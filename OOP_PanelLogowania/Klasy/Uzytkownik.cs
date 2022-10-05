using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PanelLogowania.Klasy
{
    public class Uzytkownik
    {
        public string Login { get; set; }
        public string Haslo { get; set; }
        public string Wiek { get; set; }
        public string Email { get; set; }
        

        public Uzytkownik()
        {
            Login = "admin";
            Haslo = "admin";
        }
       
        public string PrzedstawSie()
        {
            var tekst = $"Witaj {Login}";
            return tekst;
        }



    }
}
