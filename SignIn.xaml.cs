using Start.db;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

namespace Start
{
    /// <summary>
    /// Логика взаимодействия для SignIn.xaml
    /// </summary>
    public partial class SignIn : Window
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
                
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string Email = textBoxEmail.Text.Trim();
            string Pass = passBox.Password.Trim();
          

            if (Email.Length < 5 || !Email.Contains("@") || !Email.Contains("."))
            {
                textBoxEmail.ToolTip = "Колличество символов должно быть больше 5";
                textBoxEmail.Background = Brushes.DarkRed;
            }

            else if (Pass.Length < 5)
            {
                passBox.ToolTip = "Колличество символов должно быть больше 5";
                passBox.Background = Brushes.DarkRed;
            }
            else
            {
                textBoxEmail.ToolTip = "";
                textBoxEmail.Background = Brushes.Transparent;
                passBox.ToolTip = ""; 
                passBox.Background = Brushes.Transparent;

                User authUser = null;
                using (UserContext context = new UserContext())
                {
                    authUser = context.Users.Where(b => b.Email == Email && b.Pass == Pass).FirstOrDefault();
                }
                if (authUser != null)
                {
                    MessageBox.Show("Вход Совершен!");
                    HomeWin Home = new HomeWin();
                    Home.Show();
                    this.Close();
                }
                else
                    MessageBox.Show("Не корректная информация");
            }

        }
    }
}
