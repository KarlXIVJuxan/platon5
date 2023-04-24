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
using System.Windows.Navigation;
using System.Windows.Shapes;
using platon5.pl5prison2DataSetTableAdapters;

namespace platon5
{
    public partial class MainWindow : Window
    {
        AutorizationTableAdapter autorization = new AutorizationTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_click(object sender, RoutedEventArgs e)
        {
            var allLogins = autorization.GetData().Rows;
            for (int i = 0; i < allLogins.Count; i++)
            {
                if (allLogins[i][1].ToString() == LoginTbx.Text && 
                    allLogins[i][1].ToString() == PasswordTbx.Password)
                {
                    int roleId = (int)allLogins[i][3];
                    switch (roleId) 
                    {
                        case 1:
                            Firstrolewindow first = new Firstrolewindow();
                            first.Show();
                            break;
                        case 2:
                            secondrolewindow second = new secondrolewindow();
                            second.Show();
                            break;
                        case 3:
                            thirdrolewindow third = new thirdrolewindow();
                            third.Show();
                            break;
                    }
                }
            }
        }
    }
}
