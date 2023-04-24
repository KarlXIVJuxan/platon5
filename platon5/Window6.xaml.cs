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
    public partial class Window6 : Window
    {
        Event_PlaceTableAdapter @event = new Event_PlaceTableAdapter();
        public Window6()
        {
            InitializeComponent();
            EventPlace.ItemsSource = @event.GetData();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Window7 admin = new Window7();
            admin.Show();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            Window5 admin = new Window5();
            admin.Show();
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            object id = (EventPlace.SelectedItem as DataRowView).Row[0];
            @event.InsertQuery(Convert.ToInt32(TerritoryId), Convert.ToInt32(EventsID));
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            object id = (EventPlace.SelectedItem as DataRowView).Row[0];
            @event.DeleteQuery(Convert.ToInt32(id));
        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            object id = (EventPlace.SelectedItem as DataRowView).Row[0];
            @event.UpdateQuery(Convert.ToInt32(TerritoryId), Convert.ToInt32(EventsID), Convert.ToInt32(id));
        }
    }
}
