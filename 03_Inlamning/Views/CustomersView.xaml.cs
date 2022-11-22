using _03_Inlamning.Models;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace _03_Inlamning.Views
{
    /// <summary>
    /// Interaction logic for CustomersView.xaml
    /// </summary>
    public partial class CustomersView : UserControl
    {
        private SqlContext _context;
        public CustomersView()
        {
            InitializeComponent();
            _context = new SqlContext();
            GetCustomerList();
        }

        public void GetCustomerList()
        {
            var customers = _context.Customers.ToList();
            var customerOverrideList = new List<CustomerOverride>();

            foreach (var customer in customers)
            {
                var customerOverride = new CustomerOverride
                {
                    City = customer.City,
                    StreetName = customer.StreetName,
                    PhoneNumber = customer.PhoneNumber,
                    StreetNumber = customer.StreetNumber,
                    Email = customer.Email,
                    LastName = customer.LastName,
                    FirstName = customer.FirstName,
                    PostalCode = customer.PostalCode,
                };

                customerOverrideList.Add(customerOverride);
            }

            CustomerListView.ItemsSource = customerOverrideList;
        }
    }

    public class CustomerOverride
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string StreetName { get; set; } = null!;

        public int StreetNumber { get; set; }

        public int PostalCode { get; set; }

        public string City { get; set; } = null!;

        public int PhoneNumber { get; set; }

        public override string ToString()
        {
            return
                this.FirstName + ", " +
                this.LastName + ", " +
                this.Email + ", " +
                this.StreetNumber + ", " +
                this.PostalCode + ", " +
                this.PhoneNumber + ", " +
                this.City + ", " +
                this.StreetName;
        }

    }

}