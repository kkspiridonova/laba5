using lab5.KINOPROKATPRACTICA5DataSetTableAdapters;
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

namespace lab5
{
    /// <summary>
    /// Логика взаимодействия для WindowBuscket.xaml
    /// </summary>
    public partial class WindowBuscket : Window
    {
        BASCKETTableAdapter basket = new BASCKETTableAdapter();
        PRODUCERTableAdapter product = new PRODUCERTableAdapter();
        public WindowBuscket()
        {
            InitializeComponent();
            BascketDgr.ItemsSource = basket.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            basket.InsertQueryPr(Convert.ToInt32(ProductID.Text));
            BascketDgr.ItemsSource = basket.GetData();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            object id = (BascketDgr.SelectedItem as DataRowView).Row[0];
            basket.DeleteQuery(Convert.ToInt32(id));
            BascketDgr.ItemsSource = basket.GetData();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            WindowPokupatel window = new WindowPokupatel();
            window.Show();
        }
    }
}
