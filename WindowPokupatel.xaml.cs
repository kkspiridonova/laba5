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
    /// Логика взаимодействия для WindowPokupatel.xaml
    /// </summary>
    public partial class WindowPokupatel : Window
    {
        PRODUCTTableAdapter product = new PRODUCTTableAdapter();
        TYPEOFPRODUCTTableAdapter type = new TYPEOFPRODUCTTableAdapter();
        public WindowPokupatel()
        {
            InitializeComponent();
            ProductDgr.ItemsSource = product.GetData();
            ProductTypeCbx.ItemsSource = type.GetData();
            ProductTypeCbx.DisplayMemberPath = "NameOfType";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ProductDgr.ItemsSource=product.GetDataBy(SearchTxt.Text);
        }

        private void ProductTypeCbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ProductTypeCbx.SelectedItem != null)
            {
                var id = (int)(ProductTypeCbx.SelectedItem as DataRowView).Row[0];
                ProductDgr.ItemsSource = product.GetDataBy1(id);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ProductDgr.ItemsSource = product.GetData();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            WindowBuscket window = new WindowBuscket();
            window.Show();
        }
    }
}
