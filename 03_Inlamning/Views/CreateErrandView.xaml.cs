﻿using _03_Inlamning.Models;
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

namespace _03_Inlamning.Views
{ 
    public partial class CreateErrandView : UserControl
    {
        public CreateErrandView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var errand = new Errand
            {
                ErrandName = tbErrand.Text,
                ErrandId = int.Parse(tbCustomerId.Text),
                ErrandDescription = tbDescription.Text,
                CreateErrandDate = int.Parse(tbCreateDate.Text),
                ChangeErrandDate = int.Parse(tbChangeDate.Text),
                ErrandStatus = tbErrandState.Text,
            };

            using (var context = new SqlContext())
            {
                context.Errands.Add(errand);
                context.SaveChanges();
            }

        }
    }
}
