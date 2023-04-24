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
    public partial class Window5 : Window
    {
        Leisure_ActivitiesTableAdapter leisure = new Leisure_ActivitiesTableAdapter();
        public Window5()
        {
            InitializeComponent();
            LeisureActivities.ItemsSource = leisure.GetData();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Window6 admin = new Window6();
            admin.Show();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            Window4 admin = new Window4();
            admin.Show();
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            object id = (LeisureActivities.SelectedItem as DataRowView).Row[0];
            leisure.InsertQuery(QantityOfPlace.Text, NumberOfWorkPlace.Text, FreeZoneCapacity.Text, Convert.ToInt32(Territoryid));
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            object id = (LeisureActivities.SelectedItem as DataRowView).Row[0];
            leisure.DeleteQuery(Convert.ToInt32(id));
        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            object id = (LeisureActivities.SelectedItem as DataRowView).Row[0];
            leisure.UpdateQuery(QantityOfPlace.Text, NumberOfWorkPlace.Text, FreeZoneCapacity.Text, Convert.ToInt32(Territoryid), Convert.ToInt32(id));
        }
    }
}
