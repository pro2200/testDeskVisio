﻿using System;
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

namespace Assignment1
{
    /// <summary>
    /// Interaction logic for Sales.xaml
    /// </summary>
    public partial class Sales : Window
    {
        public Sales()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            double total = 0;
            double price = 0;
            double amount = 0;
            price = Convert.ToDouble(txtPrice.Text);
            amount = Convert.ToDouble(txtAmount.Text);

            total = (price * amount);

            txtTotal.Text = total.ToString();
        }
    }
}
