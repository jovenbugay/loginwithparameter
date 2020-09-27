using System;
using System.Collections.Generic;
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

namespace Loginwithparameter
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            String name = txtusername.Text;
            String password = txtpassword.Password;
            if (txtpassword.Password == "123" && txtusername.Text == "Joven")
            {
                Window win1 = new Window1(name, password);
                win1.Show();
               

            }
            else
            {
                Status.Content = "Error logging in";
            }



        }
    }
}
