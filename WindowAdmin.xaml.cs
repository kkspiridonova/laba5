using System;
using System.Collections.Generic;
using System.Data;
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
using lab5.KINOPROKATPRACTICA5DataSetTableAdapters;

namespace lab5
{
    /// <summary>
    /// Логика взаимодействия для WindowAdmin.xaml
    /// </summary>
    public partial class WindowAdmin : Window
    {
        USERSTableAdapter user = new USERSTableAdapter();
        public WindowAdmin()
        {
            InitializeComponent();
            UserDgr.ItemsSource = user.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                user.InsertUserQuery(UserName.Text, UserLastName.Text, UserLogin.Text, Convert.ToInt32(UserRole.Text));
                UserDgr.ItemsSource = user.GetData();
            }
            catch 
            {
                UserRole.Text = "Введите номер роли!";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                object id = (UserDgr.SelectedItem as DataRowView).Row[0];
                user.UpdateUserQuery(UserName.Text, UserLastName.Text, UserLogin.Text, Convert.ToInt32(UserRole.Text), Convert.ToInt32(id));
                UserDgr.ItemsSource = user.GetData();
            }
            catch
            {
                UserRole.Text = "Введите номер роли!";
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            object id = (UserDgr.SelectedItem as DataRowView).Row[0];
            user.DeleteUserQuery(Convert.ToInt32(id));
            UserDgr.ItemsSource = user.GetData();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            WindowPokupatel window = new WindowPokupatel();
            window.Show();
        }
    }
}
