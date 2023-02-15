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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Super_Market
{
    /// <summary>
    /// Interaction logic for Store.xaml
    /// </summary>
    public partial class Store : UserControl
    {
        public Store()
        {
            InitializeComponent();
            Fillgrid();
           // 
        }

        private void Fillgrid()
        {

            var stors = Sampledata.stores;
            foreach (var stor in stors)
            {
                datagrid.Items.Add(stor);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        
        private void comstore_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           // datagrid.Items.Add(comstore.SelectedItem);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Sampledata.stores.Add(new Stor { Name =txtstor.Text,Location=txtloc.Text });
            datagrid.Items.Clear();
            Fillgrid();
            txtloc.Text = "";
            txtstor.Text = "";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Data Saved In Local Memory");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void datagrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           Stor s = datagrid.SelectedItem as Stor;
           txtstor.Text = Convert.ToString(s.Name);
        }
    }
}
