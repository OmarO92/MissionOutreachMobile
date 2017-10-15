using System;
using System.Diagnostics;
using System.Collections.Generic;
using MissionOutreachMobile.Models;
using System.Threading.Tasks;

using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;


namespace MissionOutreachMobile.Views
{
    public partial class CustomerLoginPage : ContentPage
    {
        ZXingScannerPage barcodeScannerPage;

        public CustomerLoginPage()
        {
            InitializeComponent();
            UseIDButton.Clicked += UseIDButton_Clicked;
            registerButton.Clicked += RegisterButton_Clicked;
            customerListPageButton.Clicked += CustomerListPageButton_Clicked;
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            barcodeScannerPage = new ZXingScannerPage();
          //  barcodeScannerPage.IsScanning = true;
            barcodeScannerPage.Title = "Badge Scanner";
            barcodeScannerPage.OnScanResult += (result) =>
            {
               // barcodeScannerPage.IsScanning = false;
                Device.BeginInvokeOnMainThread(() =>
                {
                    Navigation.PopAsync();
                    DisplayAlert("Scanned ID", result.Text, "OK");
                    //scanResult = result.Text;
                    //EntryUserName.Text = scanResult;
                });


            };
            //barcodeScannerPage.IsScanning = false;
            await Navigation.PushAsync(barcodeScannerPage);
        }



        async void UseIDButton_Clicked(object sender, EventArgs e)
        {

            await DisplayAlert("Used ID", IdEntry.Text, "Accept", "Cancel");
            await Navigation.PushAsync(new CustomerListPage());
            //List<RestCustomers> c = new List<RestCustomers>();
            //try{
            //    c = await App.RestManager.GetAllCustomersAsync();
            //    foreach(var x in c) {
            //        Debug.WriteLine(x.FirstName);
            //    }
                                
            //}
            //catch (Exception ex) {
            //    Debug.WriteLine($"Failed to make api call {ex.Message}");
            //}
        }

        async void RegisterButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistrationPage());
        }
        //async void updateCustomer(){

        //}

        async void CustomerListPageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CustomerListPage());

        }
    }
}
