using DateTextBoxApp.CustomControls;
using DateTextBoxApp.Models;
using System;
using System.Collections.Generic;
using System.Windows;

namespace DateTextBoxApp
{
    public partial class MainWindow : Window
    {
        private int currentIndex = 0;

        List<CustomerModel> CustomerData = new List<CustomerModel>(DataAccessLayer.LoadCustomer());

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainWindowViewModel();

            var customers = DataAccessLayer.LoadCustomer();
            foreach (var customer in customers)
            {
                var dateParts = customer.DateOfBirth.Split('/');
                var dateControl = new CustomDateControl
                {
                    Day = dateParts.Length > 0 ? dateParts[0] : null,
                    Month = dateParts.Length > 1 ? dateParts[1] : null,
                    Year = dateParts.Length > 2 ? dateParts[2] : null
                };
                // Now you can use dateControl as needed
            }


            (DataContext as MainWindowViewModel).SelectedCustomer = CustomerData[currentIndex];

        }

        private void NavigationButtons_Click(object sender, RoutedEventArgs e)
        {
            if(sender == NavigatePreviousButton)
            {
                currentIndex = Math.Min(currentIndex + 1, CustomerData.Count - 1);
            }
            else if(sender == NavigateNextButton)
            {
                currentIndex = Math.Max(currentIndex - 1, 0);
            }

            (DataContext as MainWindowViewModel).SelectedCustomer = CustomerData[currentIndex];
        }
    }

}



