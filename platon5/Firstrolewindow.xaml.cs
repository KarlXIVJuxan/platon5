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
    public partial class Firstrolewindow : Window
    {
        RoleTableAdapter role = new RoleTableAdapter();
        public Firstrolewindow()
        {
            InitializeComponent();
            Role.ItemsSource = role.GetData();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Window1 admin = new Window1();
            admin.Show();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            Window9 admin = new Window9();
            admin.Show();
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            //object id = (Role.SelectedItem as DataRowView).Row[0];
            role.InsertQuery(RoleName.Text);
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            object id = (Role.SelectedItem as DataRowView).Row[0];
            role.DeleteQuery(Convert.ToInt32(id));
        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            object id = (Role.SelectedItem as DataRowView).Row[0];
            role.UpdateQuery(RoleName.Text, Convert.ToInt32(id));
        }
    }
}
