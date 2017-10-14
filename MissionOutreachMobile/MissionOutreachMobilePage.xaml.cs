using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;

namespace MissionOutreachMobile
{
    public partial class MissionOutreachMobilePage : ContentPage
    {
        ZXingScannerPage scanPage;

        public MissionOutreachMobilePage()
        {
            InitializeComponent();
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
          
            scanPage = new ZXingScannerPage();
            scanPage.OnScanResult += (result) => {
                scanPage.IsScanning = false;

                Device.BeginInvokeOnMainThread(() => {
                    Navigation.PopAsync();
                    DisplayAlert("Scanned Barcode", result.Text, "OK");
                });
            };

            await Navigation.PushAsync(scanPage);
        }
    }
}
