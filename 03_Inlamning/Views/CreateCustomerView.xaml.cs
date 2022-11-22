using _01_Inlamning.Models;
using _03_Inlamning.Models;
using System;
using System.Windows;
using System.Windows.Controls;

namespace _03_Inlamning.Views
{
    /// <summary>
    /// Interaction logic for CreateCustomerView.xaml
    /// </summary>
    public partial class CreateCustomerView : UserControl
    {
        public CreateCustomerView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var customer = new Customer
            {
                City = tbCity.Text,
                Email = tbEmail.Text,
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text,
                PostalCode = int.Parse(tbPostalCode.Text),
                PhoneNumber = int.Parse(tbPhone.Text),
                StreetNumber = int.Parse(tbStreetNumber.Text),
                StreetName = tbStreetName.Text,
            };

            using (var context = new SqlContext())
            {
                context.Customers.Add(customer);
                context.SaveChanges();
            }

        }
    }
}