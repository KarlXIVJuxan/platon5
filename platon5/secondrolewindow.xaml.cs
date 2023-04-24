using platon5.pl5prison2DataSetTableAdapters;
using System;
using System.Collections.Generic;
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

namespace platon5
{
    public partial class secondrolewindow : Window
    {
        Workers_PeopleTableAdapter workers = new Workers_PeopleTableAdapter();
        Holding_CellTableAdapter holding = new Holding_CellTableAdapter();
        PrisonersTableAdapter prisoners = new PrisonersTableAdapter();
        public secondrolewindow()
        {
            InitializeComponent();
            Worker.ItemsSource = workers.GetData();
            Prisoner.ItemsSource = prisoners.GetData();
            Holding.ItemsSource = holding.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
        }
    }
}
