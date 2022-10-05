using OOP_PanelLogowania.Klasy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_PanelLogowania
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //string login = "admin";
            //string haslo = "admin";


            var user = new Uzytkownik();
            var user2 = new Uzytkownik();

            user.Login = "giganci";
            user.Haslo = "giganci123";
            user = new Uzytkownik();
            

            if (user.Login == textBox1.Text && user.Haslo == textBox2.Text)
            {
                MessageBox.Show($"Zalogowano poprawnie. {user.PrzedstawSie()}",
                                "Komunikat",
                                 MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show($"Login lub haslo niepoprawne. Podano login: {textBox1.Text}, a szukamy loginu {user.Login}",
                               "Błąd",
                                MessageBoxButtons.OK);
            }

          

        }
    }
}
