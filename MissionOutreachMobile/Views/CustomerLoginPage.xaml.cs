using System;
using System.Collections.Generic;

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
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            barcodeScannerPage = new ZXingScannerPage();
            barcodeScannerPage.IsScanning = true;
            barcodeScannerPage.Title = "Badge Scanner";
            barcodeScannerPage.OnScanResult += (result) =>
            {
                barcodeScannerPage.IsScanning = false;
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
        }
    }
}
