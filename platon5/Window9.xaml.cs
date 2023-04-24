﻿using System;
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
    public partial class Window9 : Window
    {
        Holding_CellTableAdapter holding = new Holding_CellTableAdapter();
        public Window9()
        {
            InitializeComponent();
            HoldingCell.ItemsSource = holding.GetData();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Firstrolewindow admin = new Firstrolewindow();
            admin.Show();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            Window8 admin = new Window8();
            admin.Show();
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            object id = (HoldingCell.SelectedItem as DataRowView).Row[0];
            holding.InsertQuery(ALL.Text, Four.Text, Two.Text, One.Text, Convert.ToInt32(PrisonerID));
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            object id = (HoldingCell.SelectedItem as DataRowView).Row[0];
            holding.DeleteQuery(Convert.ToInt32(id));
        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            object id = (HoldingCell.SelectedItem as DataRowView).Row[0];
            holding.UpdateQuery(ALL.Text, Four.Text, Two.Text, One.Text, Convert.ToInt32(PrisonerID), Convert.ToInt32(id));
        }
    }
}
