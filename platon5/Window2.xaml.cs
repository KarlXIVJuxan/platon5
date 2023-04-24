using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
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
    public partial class Window2 : Window
    {
        Workers_PeopleTableAdapter workers = new Workers_PeopleTableAdapter();
        public Window2()
        {
            InitializeComponent();
            WorkersPeople.ItemsSource = workers.GetData();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Window3 admin = new Window3();
            admin.Show();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            Window1 admin = new Window1();
            admin.Show();
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            object id = (WorkersPeople.SelectedItem as DataRowView).Row[0];
            workers.InsertQuery(Workername.Text, Workersubname.Text, Convert.ToInt32(AutorizationID), Convert.ToInt32(Salaryid));
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            object id = (WorkersPeople.SelectedItem as DataRowView).Row[0];
            workers.DeleteQuery(Convert.ToInt32(id));
        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            object id = (WorkersPeople.SelectedItem as DataRowView).Row[0];
            workers.UpdateQuery(Workername.Text, Workersubname.Text, Convert.ToInt32(AutorizationID), Convert.ToInt32(Salaryid), Convert.ToInt32(id));
        }
    }
}
