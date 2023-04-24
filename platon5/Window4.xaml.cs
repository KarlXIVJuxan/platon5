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
using platon5.pl5prison2DataSetTableAdapters;

namespace platon5
{
    public partial class Window4 : Window
    {
        TerritoryTableAdapter territory = new TerritoryTableAdapter();
        public Window4()
        {
            InitializeComponent();
            Territory.ItemsSource = territory.GetData();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Window5 admin = new Window5();
            admin.Show();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            Window3 admin = new Window3();
            admin.Show();
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            object id = (Territory.SelectedItem as DataRowView).Row[0];
            territory.InsertQuery(ExtensionsName.Text, WorkPlace.Text, FreeZone.Text, Convert.ToInt32(SalaryID));
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            object id = (Territory.SelectedItem as DataRowView).Row[0];
            territory.DeleteQuery(Convert.ToInt32(SalaryID));
        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            object id = (Territory.SelectedItem as DataRowView).Row[0];
            territory.UpdateQuery(ExtensionsName.Text, WorkPlace.Text, FreeZone.Text, Convert.ToInt32(SalaryID), Convert.ToInt32(SalaryID));
        }
    }
}
