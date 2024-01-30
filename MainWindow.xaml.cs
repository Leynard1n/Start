using Start.db;
using System.Runtime;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Start
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UserContext db;

        public MainWindow()
        {
            InitializeComponent();

            db = new UserContext();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            string Email = textBoxEmail.Text;
            string Login = textBoxLogin.Text;
            string Pass = passBox.Password;
            string pass_2 = passBox_2.Password;

            if (Email.Length < 5 || !Email.Contains("@") || !Email.Contains("."))
            {
                textBoxEmail.ToolTip = "Колличество символов должно быть больше 5";
                textBoxEmail.Background = Brushes.DarkRed;
            }
            
            else if (Login.Length < 5)
            {
                textBoxLogin.ToolTip = "Колличество символов должно быть больше 5";
                textBoxLogin.Background = Brushes.DarkRed;
            }
            else if (Pass.Length < 5)
            {
                passBox.ToolTip = "Колличество символов должно быть больше 5";
                passBox.Background = Brushes.DarkRed;
            }
            else if (Pass != pass_2)
            {
                passBox_2.ToolTip = "Колличество символов должно быть больше 5";
                passBox_2.Background = Brushes.DarkRed;
            }
            else
            {
                textBoxEmail.ToolTip = "";
                textBoxEmail.Background = Brushes.Transparent;
                textBoxLogin.ToolTip = "";
                textBoxLogin.Background = Brushes.Transparent;
                passBox.ToolTip = "";
                passBox.Background = Brushes.Transparent;
                passBox_2.ToolTip = "";
                passBox_2.Background = Brushes.Transparent;

                MessageBox.Show("Зарегестрированы успешно!");

                User user = new User(Login,Pass,Email);
                db.Users.Add(user);
                db.SaveChanges();

                HomeWin Home = new HomeWin();
                Home.Show();
                this.Close();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           SignIn signIn = new SignIn();
            signIn.Show();
            this.Close();
        }

        
    }
}