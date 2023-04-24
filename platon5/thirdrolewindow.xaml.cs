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
using platon5.pl5prison2DataSetTableAdapters;

namespace platon5
{
    public partial class thirdrolewindow : Window
    {
        SalaryTableAdapter salary = new SalaryTableAdapter();
        TerritoryTableAdapter territory = new TerritoryTableAdapter();
        public thirdrolewindow()
        {
            InitializeComponent();
            Salaryt.ItemsSource = salary.GetData();
            Territoryt.ItemsSource = territory.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
        }
    }
}
