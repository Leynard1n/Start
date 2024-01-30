using Start.db;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
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
    /// Логика взаимодействия для HomeWin.xaml
    /// </summary>
    public partial class HomeWin : Window
    {
        UserContext db;
        public static HomeWin Window;
        int k = 1;
        public HomeWin()
        {
            InitializeComponent();
            Window = this;
            db = new UserContext();

            List<User> logins = db.Users.ToList();
            string lOG = "";
            foreach (User user in logins) 
                lOG += "UserName :" + user.Login ;
            
            UserName.Text = lOG;
        }
    
        

        private void Drag (object sender, RoutedEventArgs e) 
        { 
            if (Mouse.LeftButton == MouseButtonState.Pressed)
            {
                HomeWin.Window.DragMove();
            }
        }

        private void CloseBut_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ZiBut_Click(object sender, RoutedEventArgs e)
        {
            _ = Application.Current.Windows
            ; { HomeWin.Window.WindowState = WindowState.Minimized; }
        }

        private void MaxButton_Click(object sender, RoutedEventArgs e)
        {
            k++;
            if (k % 2 == 0)
            {
                _ = Application.Current.Windows;
                {
                    HomeWin.Window.WindowState = WindowState.Maximized;
                }
            }
            else
            {
                _ = Application.Current.Windows;
                { HomeWin.Window.WindowState = WindowState.Normal; }
            }
            
        }
    }
}
