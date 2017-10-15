using Xamarin.Forms;
using MissionOutreachMobile.Views;
using MissionOutreachMobile.Data;

namespace MissionOutreachMobile
{
    public partial class App : Application
    {
        public static RestServiceManager RestManager { get; private set; }
        static MissionOutreachMobileDatabase database;
        public App()
        {
            InitializeComponent();

            RestManager = new RestServiceManager(new RestService());

            MainPage = new NavigationPage(new CustomerLoginPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        public static MissionOutreachMobileDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new MissionOutreachMobileDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("OutreachSQLite.db3"));
                }
                return database;
            }
        }
    }
}
