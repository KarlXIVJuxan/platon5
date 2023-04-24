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
    public partial class Window1 : Window
    {
        AutorizationTableAdapter autorization = new AutorizationTableAdapter();
        public Window1()
        {
            InitializeComponent();
            Autorization.ItemsSource = autorization.GetData();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Window2 admin = new Window2();
            admin.Show();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            Firstrolewindow admin = new Firstrolewindow();
            admin.Show();
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            object id = (Autorization.SelectedItem as DataRowView).Row[0];
            autorization.InsertQuery(Login.Text, Password.Text, Convert.ToInt32(RoleID));
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            object id = (Autorization.SelectedItem as DataRowView).Row[0];
            autorization.DeleteQuery(Convert.ToInt32(id));
        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            object id = (Autorization.SelectedItem as DataRowView).Row[0];
            autorization.UpdateQuery(Login.Text, Password.Text, Convert.ToInt32(RoleID), Convert.ToInt32(id));
        }
    }
}
