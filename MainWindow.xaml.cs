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
       
        public MainWindow()
        {
            InitializeComponent();
            
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Color newColor = Color.FromArgb(124 , 10 ,2 ,50);
            string email = textBoxEmail.Text;
            string login = textBoxLogin.Text;
            string pass = passBox.Password;
            string pass_2 = passBox_2.Password;

            if (email.Length < 5 || !email.Contains("@") || !email.Contains("."))
            {
                textBoxEmail.ToolTip = "Колличество символов должно быть больше 5";
                textBoxEmail.Background = Brushes.DarkRed;
            }
            
            else if (login.Length < 5)
            {
                textBoxLogin.ToolTip = "Колличество символов должно быть больше 5";
                textBoxLogin.Background = Brushes.DarkRed;
            }
            else if (pass.Length < 5)
            {
                passBox.ToolTip = "Колличество символов должно быть больше 5";
                passBox.Background = Brushes.DarkRed;
            }
            else if (pass != pass_2)
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
                
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           SignIn signIn = new SignIn();
            signIn.Show();
            Hide();
        }

        
    }
}