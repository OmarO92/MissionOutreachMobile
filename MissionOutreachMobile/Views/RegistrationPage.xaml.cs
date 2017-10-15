using System;
using System.Diagnostics;
using System.Collections.Generic;
using MissionOutreachMobile.Data;
using MissionOutreachMobile.Models;
using Xamarin.Forms;

namespace MissionOutreachMobile.Views
{
    public partial class RegistrationPage : ContentPage
    {
        Customer customer;
        public RegistrationPage()
        {
            InitializeComponent();
            signUpButton.Clicked += SignUpButton_Clicked;
            customer = new Customer();
            customer.Name = firstNameEntry.Text + "  " + lastNameEntry.Text;
           // customer.DOB = dobEntry.Text;
            customer.Status = "Unknown";
            customer.ImageUrl = "http://lorempixel.com/100/100/nature/4";

        }

        void SignUpButton_Clicked(object sender, EventArgs e)
        {
            customer.Name = firstNameEntry.Text + "  " + lastNameEntry.Text;
            // customer.DOB = dobEntry.Text;
            customer.Status = "Unknown";
            customer.ImageUrl = "http://lorempixel.com/100/100/nature/4";
            Debug.WriteLine($"Inserting {customer.Name}");
            App.Database.RegisterCustomerAsync(customer);
        }

    }
}
