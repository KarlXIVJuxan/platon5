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
    public partial class Window8 : Window
    {
        PrisonersTableAdapter prisoners = new PrisonersTableAdapter();
        public Window8()
        {
            InitializeComponent();
            Prisoners.ItemsSource = prisoners.GetData();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Window9 admin = new Window9();
            admin.Show();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            Window7 admin = new Window7();
            admin.Show();
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            object id = (Prisoners.SelectedItem as DataRowView).Row[0];
            prisoners.InsertQuery(All_Prisoners.Text, Serious.Text, Average.Text, Light.Text);
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            object id = (Prisoners.SelectedItem as DataRowView).Row[0];
            prisoners.DeleteQuery(Convert.ToInt32(id));
        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            object id = (Prisoners.SelectedItem as DataRowView).Row[0];
            prisoners.UpdateQuery(All_Prisoners.Text, Serious.Text, Average.Text, Light.Text, Convert.ToInt32(id));
        }
    }
}
