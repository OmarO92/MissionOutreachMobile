using System;
using System.Collections.Generic;
using MissionOutreachMobile.Models;

using Xamarin.Forms;

namespace MissionOutreachMobile.Views
{
    public partial class CustomerListPage : ContentPage
    {
        public CustomerListPage()
        {
            InitializeComponent();
            customerListView.ItemsSource = new List<CustomerGroup>
            {
                new CustomerGroup("In", "In") {
                    new Customer {Identification= "123" , Name = "Allen", ImageUrl="http://lorempixel.com/100/100/city/1", Status = "In"},
                    new Customer {Identification = "456", Name = "Martha", ImageUrl="http://lorempixel.com/100/100/city/2", Status = "In"},
                    new Customer {Identification = "102", Name = "Jayshawn",ImageUrl="http://lorempixel.com/100/100/city/8", Status = "In"  },


                },
                new CustomerGroup("N/A", "N/A") {
                    new Customer { Identification = "456", Name = "Mary", ImageUrl="http://lorempixel.com/100/100/city/5", Status = "Unknown"},
                    new Customer { Identification = "789", Name = "Dan", ImageUrl="http://lorempixel.com/100/100/city/3", Status = "Unknown"},
                    new Customer { Identification = "101", Name = "Maddie", ImageUrl="http://lorempixel.com/100/100/city/4", Status = "Unknown"},


                }



            };
        }
    }
}
