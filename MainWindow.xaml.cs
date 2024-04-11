using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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

namespace lab5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtAvtor_Click(object sender, RoutedEventArgs e)
        {
            if (PaswdBx.Password == "123456789")
            {
                WindowAdmin window = new WindowAdmin();
                window.Show();
            }
            else if (PaswdBx.Password == "1111")
            {
                WindowPokupatel window = new WindowPokupatel();
                window.Show();
            }
            else 
            {
                OschibkaTblck.Text = "Неверный пароль";
            }
        }
           
    }
}

               
 

